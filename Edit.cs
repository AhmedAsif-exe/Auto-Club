using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Auto_Club
{
    public partial class Edit : Form
    {
        public Edit(string car_num)
        {
            InitializeComponent();

            get_data(car_num);
        }
        void get_data(string car_num)
        {
            string connection_string = "Data Source=PROGRAMMACHINE\\SQLEXPRESS;Initial Catalog=AutoClub;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                textBox1.Text = car_num;
                string query = "select * from cars where car_number = @carnum";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@carnum", car_num);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                textBox2.Text = (reader.IsDBNull(1) ? "N/A" : reader.GetString(1));
                                textBox3.Text = (reader.IsDBNull(2) ? "N/A" : reader.GetString(2));
                                textBox5.Text = (reader.IsDBNull(3) ? "N/A" : reader.GetString(3));
                                textBox9.Text = (reader.IsDBNull(4) ? "N/A" : reader.GetString(4));
                                textBox4.Text = (reader.IsDBNull(5) ? "N/A" : reader.GetString(5));
                                textBox8.Text = (reader.IsDBNull(6) ? "N/A" : reader.GetString(6));
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message);
                            }

                        }
                    }
                    else MessageBox.Show("No Results Found");
                }
            }
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
            string connection_string = "Data Source=PROGRAMMACHINE\\SQLEXPRESS;Initial Catalog=AutoClub;Integrated Security=True";

            string query = "UPDATE cars SET " +
                    "maker = @maker, " +
                    "model = @model, " +
                    "engine_number = @engine_number, " +
                    "chassis_number = @chassis_number, " +
                    "color = @color, " +
                    "status = @status " +
                    "WHERE car_number = @car_number";

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
                    catch (Exception ex)
                    {
                        // Handle exceptions
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }
    }
}
