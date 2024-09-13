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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string car_number = textBox1.Text.Trim();
            string maker = textBox2.Text.Trim();
            string model = textBox3.Text.Trim();
            string color = textBox4.Text.Trim();
            string engine_number = textBox5.Text.Trim();
            string status = textBox8.Text.Trim();
            string chassis_number = textBox9.Text.Trim();

            if (String.IsNullOrEmpty(car_number))
                return;
            if (String.IsNullOrEmpty(maker))
                return;
            if (String.IsNullOrEmpty(model))
                return;
            if (String.IsNullOrEmpty(color))
                return;
            if (String.IsNullOrEmpty(engine_number))
                return;
            if (String.IsNullOrEmpty(status))
                return;
            if (String.IsNullOrEmpty(chassis_number))
                return;
            string connection_string = "Data Source=DESKTOP-MAO1OJ0\\SQLEXPRESS;Initial Catalog=AutoClub;Integrated Security=True";

            string query = "INSERT INTO cars (car_number, maker, model, engine_number, chassis_number, color, status) " +
                            "VALUES (@car_number, @maker, @model, @engine_number, @chassis_number, @color, @status)";


            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    // Add parameters to the command
                    command.Parameters.AddWithValue("@car_number", car_number);
                    command.Parameters.AddWithValue("@maker", maker);
                    command.Parameters.AddWithValue("@model", model);
                    command.Parameters.AddWithValue("@engine_number", engine_number);
                    command.Parameters.AddWithValue("@chassis_number", chassis_number);
                    command.Parameters.AddWithValue("@color", color);
                    command.Parameters.AddWithValue("@status", status);

                    try
                    {
                        // Open the connection and execute the command
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            MessageBox.Show("Data inserted successfully.");
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627 || ex.Number == 2601)
                        {
                            MessageBox.Show("Car Number already exists");
                        }
                        else
                        {
                            // Display other SQL errors
                            MessageBox.Show("An SQL error occurred: " + ex.Message);
                        }
                    }



                }
            }
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
