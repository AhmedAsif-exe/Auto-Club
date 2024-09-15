using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Auto_Club
{
    public partial class Rent_History : Form
    {
        public Rent_History()
        {
            InitializeComponent();
            create_table();
        }
        void create_table()
        {
            //dataGridView1.Columns.Add("name", "Customer Name");
            //dataGridView1.Columns.Add("cnic", "CNIC");
            //dataGridView1.Columns.Add("phone_number", "Phone Number");
            //dataGridView1.Columns.Add("parent_name", "Parent Name");
            //dataGridView1.Columns.Add("phone_residence", "Residence Phone");
            //dataGridView1.Columns.Add("current_residence", "Current Residence");
            //dataGridView1.Columns.Add("guarantor_name", "Guarantor Name");
            //dataGridView1.Columns.Add("guarantor_cnic", "Guarantor CNIC");
            //dataGridView1.Columns.Add("guarantor_phone_number", "Guarantor Phone");
            //dataGridView1.Columns.Add("guarantor_parent_name", "Guarantor Parent Name");
            //dataGridView1.Columns.Add("guarantor_phone_residence", "Guarantor Residence Phone");
            //dataGridView1.Columns.Add("guarantor_current_residence", "Guarantor Current Residence");
            //dataGridView1.Columns.Add("car_number", "Car Number");
            //dataGridView1.Columns.Add("maker", "Maker");
            //dataGridView1.Columns.Add("model", "Model");
            //dataGridView1.Columns.Add("engine_number", "Engine Number");
            //dataGridView1.Columns.Add("chassis_number", "Chassis Number");
            //dataGridView1.Columns.Add("color", "Color");
            //dataGridView1.Columns.Add("rental_date", "Rental Date");
            //dataGridView1.Columns.Add("return_date", "Return Date");
            //dataGridView1.Columns.Add("destination", "Destination");



        }
        private void button1_Click(object sender, EventArgs e)
        {

            string connection_string = ConfigurationManager.ConnectionStrings["DB_CONNECTION_STRING"].ConnectionString;
            DateTime FromDate = dateTimePicker4.Value;
            DateTime ToDate = dateTimePicker3.Value;
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                string query = @"
                                SELECT rental_id, name, cnic, phone_number, parent_name, phone_residence, current_residence, guarantor_name, guarantor_cnic, guarantor_phone_number, guarantor_parent_name, guarantor_phone_residence, guarantor_current_residence, car_number, maker, model, engine_number, chassis_number, color, rental_date, return_date, destination
                                FROM customer_cars cc
                                INNER JOIN customers c ON cc.customer_id = c.customer_id
                                INNER JOIN cars ON cc.car_id = cars.car_number
                                ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@start_date", FromDate);
                    cmd.Parameters.AddWithValue("@end_date", ToDate);
                    try { 
                            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind data to DataGridView
                            dataGridView1.DataSource = dataTable;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An SQL error occurred: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }

                }
            }
        }

        private void Rent_History_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
