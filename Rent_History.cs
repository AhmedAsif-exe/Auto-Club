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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Dashboard dashboard = new Dashboard();
            //dashboard.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connection_string = "Data Source=PROGRAMMACHINE\\SQLEXPRESS;Initial Catalog=AutoClub;Integrated Security=True";
            string FromDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string ToDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                string query = @"
                                SELECT name, cnic, phone_number, guarantor_name, car_number, maker, model, rental_date, return_date 
FROM customer_cars cc
INNER JOIN customers c ON cc.customer_id = c.customer_id
INNER JOIN cars ON cc.car_id = cars.car_number
WHERE cc.rental_date BETWEEN @start_date AND @end_date;
                                ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@start_date", FromDate);
                    cmd.Parameters.AddWithValue("@end_date", ToDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;

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
    }
}
