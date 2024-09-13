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

            dataGridView1.Columns.Add("name", "Customer Name");
            dataGridView1.Columns.Add("cnic", "CNIC");
            dataGridView1.Columns.Add("phone_number", "Phone Number");
            dataGridView1.Columns.Add("guarantor_name", "Guarantor Name");
            dataGridView1.Columns.Add("car_number", "Car Number");
            dataGridView1.Columns.Add("maker", "Car Maker");
            dataGridView1.Columns.Add("model", "Car Model");
            dataGridView1.Columns.Add("rental_date", "Rental Date");
            dataGridView1.Columns.Add("return_date", "Return Date");
            dataGridView1.Columns.Add("destination", "Destination");


        }
        private void button1_Click(object sender, EventArgs e)
        {

            string connection_string = "Data Source=DESKTOP-MAO1OJ0\\SQLEXPRESS;Initial Catalog=AutoClub;Integrated Security=True";
            DateTime FromDate = dateTimePicker4.Value;
            DateTime ToDate = dateTimePicker3.Value;
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                string query = @"
                                SELECT name, cnic, phone_number, guarantor_name, car_number, maker, model, rental_date, return_date, destination
                                FROM customer_cars cc
                                INNER JOIN customers c ON cc.customer_id = c.customer_id
                                INNER JOIN cars ON cc.car_id = cars.car_number
                                WHERE cc.rental_date BETWEEN @start_date AND @end_date;
                                ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@start_date", FromDate);
                    cmd.Parameters.AddWithValue("@end_date", ToDate);

                    SqlDataReader reader = cmd.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridView1);

                            // Read values from the reader and set them to the row
                            row.Cells[0].Value = reader["name"].ToString();
                            row.Cells[1].Value = reader["cnic"].ToString();
                            row.Cells[2].Value = reader["phone_number"].ToString();
                            row.Cells[3].Value = reader["guarantor_name"].ToString();
                            row.Cells[4].Value = reader["car_number"].ToString();
                            row.Cells[5].Value = reader["maker"].ToString();
                            row.Cells[6].Value = reader["model"].ToString();
                            row.Cells[7].Value = Convert.ToDateTime(reader["rental_date"]);
                            row.Cells[8].Value = Convert.ToDateTime(reader["return_date"]);
                            row.Cells[9].Value = reader["destination"].ToString();
                            // Add the row to the DataGridView
                            dataGridView1.Rows.Add(row);
                        }
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
