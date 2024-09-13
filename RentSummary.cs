using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Club
{
    struct Summary_state
    {

    public    string rental_id;
    public    string date;
    public    string carNum;
    public    string maker;
    public    string model;
    public    string engine_num;
    public    string chassis_num;
    public    string color;

    public    string name;
    public    string parent_name;
    public    string cnic;
    public    string phone_number;
    public    string residence;
    public    string phone_address;

    public    string g_name;
    public    string g_parent_name;
    public    string g_cnic;
    public    string g_phone_number;
    public    string g_residence;
    public    string g_phone_address;
    
    public    string rental_date;
    public    string return_date;
    }
    public partial class RentSummary : Form
    {
        Summary_state state;
        string car_num;
        int customer_id;
        public RentSummary(string car_num, int customer_id)
        {
            InitializeComponent();
            this.car_num = car_num;
            this.customer_id = customer_id;

            get_car();
            get_customers();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

        }
        void get_car()
        {
            string connection_string = "Data Source=PROGRAMMACHINE\\SQLEXPRESS;Initial Catalog=AutoClub;Integrated Security=True";
            //Data Source=PROGRAMMACHINE\\SQLEXPRESS;Initial Catalog=AutoClub;Integrated Security=True
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                connection.Open();

                string query = @"select car_number, maker, model, engine_number, chassis_number, color from cars where car_number = @car_number";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@car_number", car_num);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        carNum.Text = reader.GetString(0);
                        state.carNum = carNum.Text;
                        Maker.Text = reader.GetString(1);
                        state.maker = Maker.Text;
                        Model.Text = reader.GetString(2);
                        state.model = Model.Text;
                        EngineNumber.Text = reader.GetString(3);
                        state.engine_num = EngineNumber.Text;
                        Chassis.Text = reader.GetString(4);
                        state.chassis_num = Chassis.Text;
                        state.color = reader.GetString(5);
                    }
                }
            }
        }
        void get_customers()
        {
            string connection_string = "Data Source=PROGRAMMACHINE\\SQLEXPRESS;Initial Catalog=AutoClub;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                connection.Open();

                string query = @"select * from customers where customer_id = @customer_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@customer_id", customer_id);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Name.Text = reader["name"].ToString();
                        state.name = Name.Text;
                        state.parent_name = reader["parent_name"].ToString();
                        state.phone_address = reader["phone_residence"].ToString();

                        cnic.Text = reader["cnic"].ToString();
                        state.cnic = cnic.Text;
                        phone_number.Text = reader["phone_number"].ToString();
                        state.phone_number = phone_number.Text;
                        state.residence = reader["current_residence"].ToString();
                        
                        guarantor_name.Text = reader["guarantor_name"].ToString();
                        state.g_name = guarantor_name.Text;
                        guarantor_phone.Text = reader["guarantor_phone_number"].ToString();
                        state.g_phone_number = guarantor_phone.Text;
                        state.g_cnic = reader["guarantor_cnic"].ToString();
                        state.g_residence = reader["guarantor_current_residence"].ToString();
                        state.g_parent_name = reader["guarantor_parent_name"].ToString();
                        state.g_phone_address = reader["guarantor_phone_residence"].ToString();

                    }
                }
            }
        }
        void save_to_db()
        {
            string connection_string = "Data Source=PROGRAMMACHINE\\SQLEXPRESS;Initial Catalog=AutoClub;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                string rental_date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string return_date = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                string query = "INSERT INTO customer_cars (customer_id, car_id, rental_date, return_date) " +
                                                  "VALUES (@customer_id, @car_id, @rental_date, @return_date)" +
                                                  "SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customer_id", this.customer_id);
                    cmd.Parameters.AddWithValue("@car_id", this.car_num);
                    cmd.Parameters.AddWithValue("@rental_date", rental_date);
                    cmd.Parameters.AddWithValue("@return_date", return_date);

                    var newId = cmd.ExecuteScalar();
                    state.rental_id = newId.ToString();
                    state.rental_date = rental_date;
                    state.return_date = return_date;
                    state.date = rental_date;
                }

                string query_2 = @"update cars 
                                set status = 'Not Available'
                                where car_number = @car_num";
                using (SqlCommand cmd = new SqlCommand(query_2, conn))
                {
                    cmd.Parameters.AddWithValue("@car_num", this.car_num);
                    cmd.ExecuteNonQuery();
                }





            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Set up the fonts and formatting
            Font titleFont = new Font("Arial", 20, FontStyle.Bold);
            Font sectionFont = new Font("Arial", 14, FontStyle.Underline);
            Font regularFont = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            // Set starting points for text layout
            int startX = 50;
            int startY = 50;
            int lineHeight = 30;

            // Company Name and Details
            e.Graphics.DrawString("Auto Club Rent A Car", titleFont, brush, startX, startY);
            e.Graphics.DrawString("B-1, National Market, Satellite Town, Rawalpindi", regularFont, brush, startX, startY + lineHeight);
            e.Graphics.DrawString("0333-4560077 | 0313-5555477", regularFont, brush, startX, startY + (lineHeight * 2));

            // Rental Agreement Number and Date
            e.Graphics.DrawString($"Rental Agreement No: {state.rental_id}", regularFont, brush, startX, startY + (lineHeight * 4));
            e.Graphics.DrawString($"Date: {state.date}", regularFont, brush, startX, startY + (lineHeight * 5));

            // Customer Information
            e.Graphics.DrawString("Customer Information", sectionFont, brush, startX, startY + (lineHeight * 7));
            e.Graphics.DrawString($"Name: {state.name}", regularFont, brush, startX, startY + (lineHeight * 8));
            e.Graphics.DrawString($"Father's/Husband's Name: {state.parent_name}", regularFont, brush, startX + 350, startY + (lineHeight * 8));
            e.Graphics.DrawString($"CNIC Number: {state.cnic}", regularFont, brush, startX, startY + (lineHeight * 9));
            e.Graphics.DrawString($"Phone Number: {state.phone_number}", regularFont, brush, startX + 350, startY + (lineHeight * 9));
            e.Graphics.DrawString($"Residential Address: {state.residence}", regularFont, brush, startX, startY + (lineHeight * 10));
            e.Graphics.DrawString($"Phone Address: {state.phone_address}", regularFont, brush, startX, startY + (lineHeight * 11));
           
            e.Graphics.DrawString("Guarantor Information", sectionFont, brush, startX, startY + (lineHeight * 13));
            e.Graphics.DrawString($"Name: {state.g_name}", regularFont, brush, startX, startY + (lineHeight * 14));
            e.Graphics.DrawString($"Father's/Husband's Name: {state.g_parent_name}", regularFont, brush, startX + 350, startY + (lineHeight * 14));
            e.Graphics.DrawString($"CNIC Number: {state.g_cnic}", regularFont, brush, startX, startY + (lineHeight * 15));
            e.Graphics.DrawString($"Phone Number: {state.g_phone_number}", regularFont, brush, startX + 350, startY + (lineHeight * 15));
            e.Graphics.DrawString($"Residential Address: {state.g_residence}", regularFont, brush, startX, startY + (lineHeight * 16));
            e.Graphics.DrawString($"Phone Address: {state.g_phone_address}", regularFont, brush, startX, startY + (lineHeight * 17));

            // Vehicle Information
            e.Graphics.DrawString("Vehicle Information", sectionFont, brush, startX, startY + (lineHeight * 19));
            e.Graphics.DrawString($"Registration Number: {state.carNum}", regularFont, brush, startX, startY + (lineHeight * 20));
            e.Graphics.DrawString($"Make: {state.maker}", regularFont, brush, startX + 400, startY + (lineHeight * 20));
            e.Graphics.DrawString($"Model: {state.model}", regularFont, brush, startX, startY + (lineHeight * 21));
            e.Graphics.DrawString($"Engine Number: {state.engine_num}", regularFont, brush, startX + 400, startY + (lineHeight * 21));
            e.Graphics.DrawString($"Chassis Number: {state.chassis_num}", regularFont, brush, startX,startY + (lineHeight * 22));
            e.Graphics.DrawString($"Color: _______________________________________", regularFont, brush, startX + 400, startY + (lineHeight * 22));

            e.Graphics.DrawString($"Rental Start Date: ___________________________", regularFont, brush, startX, startY + (lineHeight * 23));
            e.Graphics.DrawString($"Rental End Date: ____________________________", regularFont, brush, startX + 400, startY + (lineHeight * 23));
            e.Graphics.DrawString("Daily Rate: ________________________________", regularFont, brush, startX, startY + (lineHeight * 24));
            e.Graphics.DrawString("Total Amount: ______________________________", regularFont, brush, startX + 400, startY + (lineHeight * 24));


            // Signatures
            e.Graphics.DrawString("Signatures", sectionFont, brush, startX, startY + (lineHeight * 26));
            e.Graphics.DrawString("Customer: _____________________________", regularFont, brush, startX, startY + (lineHeight * 27));
            e.Graphics.DrawString("Witness: ______________________________", regularFont, brush, startX + 350, startY + (lineHeight * 27));
            e.Graphics.DrawString("Company Representative: __________________", regularFont, brush, startX, startY + (lineHeight * 28));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            save_to_db();

            PrintDialog print = new PrintDialog();

            print.Document = printDocument1;
            DialogResult result = print.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }

            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Customer customer = new Customer(car_num);
            //customer.Show();

            this.Close();

        }

        private void RentSummary_Load(object sender, EventArgs e)
        {

        }
    }
}
