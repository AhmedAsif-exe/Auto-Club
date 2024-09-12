using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Club
{
    public partial class RentSummary : Form
    {
        string car_num;
        int customer_id;
        public RentSummary(string car_num, int customer_id)
        {
            InitializeComponent();
            this.car_num = car_num;
            this.customer_id = customer_id;

            get_car();
            get_customers();

        }
        void get_car()
        {
            string connection_string = "Data Source=PROGRAMMACHINE\\SQLEXPRESS;Initial Catalog=AutoClub;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                connection.Open();

                string query = @"select car_number, maker, model, engine_number, chassis_number from cars where car_number = @car_number";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@car_number", car_num);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        carNum.Text = reader.GetString(0);
                        Maker.Text = reader.GetString(1);
                        Model.Text = reader.GetString(2);
                        EngineNumber.Text = reader.GetString(3);
                        Chassis.Text = reader.GetString(4);
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

                string query = @"select name, cnic, phone_number, guarantor_name,  guarantor_phone_number from customers where customer_id = @customer_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@customer_id", customer_id);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Name.Text = reader.GetString(0);
                        cnic.Text = reader.GetString(1);
                        phone_number.Text = reader.GetString(2);
                        guarantor_name.Text = reader.GetString(3);
                        guarantor_phone.Text = reader.GetString(4);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connection_string = "Data Source=PROGRAMMACHINE\\SQLEXPRESS;Initial Catalog=AutoClub;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                string rental_date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string return_date = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                string query = "INSERT INTO customer_cars (customer_id, car_id, rental_date, return_date) " +
                                                  "VALUES (@customer_id, @car_id, @rental_date, @return_date)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customer_id", this.customer_id);
                    cmd.Parameters.AddWithValue("@car_id", this.car_num);
                    cmd.Parameters.AddWithValue("@rental_date", rental_date);
                    cmd.Parameters.AddWithValue("@return_date", return_date);

                    cmd.ExecuteNonQuery();
                }

                string query_2 = @"update cars 
                                set status = 'Not Available'
                                where car_number = @car_num";
                using (SqlCommand cmd = new SqlCommand(query_2, conn))
                {
                    cmd.Parameters.AddWithValue("@car_num", this.car_num);
                    cmd.ExecuteNonQuery();
                }




                //Dashboard dashboard = new Dashboard();
                //dashboard.Show();
                this.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Customer customer = new Customer(car_num);
            //customer.Show();

            this.Close();

        }
    }
}
