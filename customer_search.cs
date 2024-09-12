using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Club
{
    public partial class customer_search : Form
    {
        public customer_search()
        {
            InitializeComponent();
            make_table();
        }
        void make_table()
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Cnic", "Cnic");
            dataGridView1.Columns.Add("Phone Number", "Phone Number");

            // Create a new button column
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();

            // Set the properties of the button column
            buttonColumn.Name = "Action";
            buttonColumn.HeaderText = "Action";
            buttonColumn.Text = "See Details";  // This will be displayed as the text on the button
            buttonColumn.UseColumnTextForButtonValue = true;  // Use the same text for all buttons

            // Add the button column to the DataGridView
            dataGridView1.Columns.Add(buttonColumn);

            dataGridView1.CellContentClick += cell_click_handler;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Dashboard dashboard = new Dashboard();
            //dashboard.Show();
            this.Close();
        }

        void cell_click_handler(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Action"].Index && e.RowIndex >= 0)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                customer_edit customer = new customer_edit(Convert.ToInt32(id));
                customer.FormClosed += (s, args) => this.Show();
                this.Hide();
                customer.Show();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string connection_string = "Data Source=PROGRAMMACHINE\\SQLEXPRESS;Initial Catalog=AutoClub;Integrated Security=True";
            string sub_name = textBox1.Text.Trim();
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                string query = "select customer_id, name, cnic, phone_number from customers WHERE name LIKE @substring";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@substring", "%" + sub_name + "%");

                    SqlDataReader reader = cmd.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            int id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);

                            string name = reader.IsDBNull(1) ? "N/A" : reader.GetString(1);
                            string cnic = reader.IsDBNull(2) ? "N/A" : reader.GetString(2);
                            string phone_number = reader.IsDBNull(3) ? "N/A" : reader.GetString(3);


                            dataGridView1.Rows.Add(id, name, cnic, phone_number);
                        }

;
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
    }
}
