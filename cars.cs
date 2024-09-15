using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; using System.Configuration;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Club
{
    public partial class cars : Form
    {
        public cars()
        {
            InitializeComponent();
            load_form();
            button1_Click(Owner, new EventArgs());
        }
        void load_form()
        {
            dataGridView1.Columns.Add("Car Number", "Car Number");
            dataGridView1.Columns.Add("Maker", "Maker");
            dataGridView1.Columns.Add("Model", "Model");
            dataGridView1.Columns.Add("Engine Number", "Engine Number");
            dataGridView1.Columns.Add("Chassis", "Chassis");
            dataGridView1.Columns.Add("Color", "Color");
            dataGridView1.Columns.Add("Status", "Status");

            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true; // Display text on buttons
            dataGridView1.Columns.Add(editButtonColumn);

            dataGridView1.CellClick += cell_click_handler;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Create the Edit button column
        }
        void cell_click_handler(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridView1.Columns["Edit"].Index))
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["Car Number"].Value.ToString();

                Edit edit = new Edit(id);
                edit.FormClosed += (s, args) => { 
                    this.Show();
                    button1.PerformClick();
                };
                this.Hide();
                edit.Show();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string connection_string = ConfigurationManager.ConnectionStrings["DB_CONNECTION_STRING"].ConnectionString;
            string car_number = textBox1.Text.Trim();
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                string query = "SELECT * FROM cars WHERE car_number LIKE @substring";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@substring", "%" + car_number + "%");

                    SqlDataReader reader = cmd.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            string car_num = reader.IsDBNull(0) ? "N/A" : reader.GetString(0);
                            string maker = reader.IsDBNull(1) ? "N/A" : reader.GetString(1);
                            string model = reader.IsDBNull(2) ? "N/A" : reader.GetString(2);
                            string engine = reader.IsDBNull(3) ? "N/A" : reader.GetString(3);
                            string chassis = reader.IsDBNull(4) ? "N/A" : reader.GetString(4);

                            string color = reader.IsDBNull(5) ? "N/A" : reader.GetString(5);
                            string status = reader.IsDBNull(6) ? "N/A" : reader.GetString(6);

                            dataGridView1.Rows.Add(car_num, maker, model, engine, chassis, color, status);
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Dashboard dashboard = new Dashboard();
            //dashboard.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.FormClosed += (s, args) =>
            {
                this.Show(); // Show the main form
            };
            add.Show();
            this.Hide();
        }
    }
}
