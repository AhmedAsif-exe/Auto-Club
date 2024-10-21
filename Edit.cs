using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;

namespace Auto_Club
{
    public partial class Edit : Form
    {
        bool isRented = false;
        string car_id = "";
        public Edit(string car_num)
        {
            this.car_id = car_num;
            InitializeComponent();
            isRented = render_date_condition(car_num);
            get_data(car_num);
        }
        void get_data(string car_num)
        {
            string connection_string = ConfigurationManager.ConnectionStrings["DB_CONNECTION_STRING"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                textBox1.Text = car_num;
                string query = "select * from cars where car_number = @carnum";
                string avalible_status = "";
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
                                avalible_status = (reader.IsDBNull(6) ? "N/A" : reader.GetString(6));
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message);
                            }

                        }
                    }
                    else MessageBox.Show("No Results Found");
                }
                if (avalible_status == "Available")
                {
                    //available
                    radioButton1.Checked = true;
                }
                else if (avalible_status == "Not Available")
                {
                    //not available
                    radioButton2.Checked = true;
                }
            }
        }
        bool render_date_condition(string car_num)
        {
            string connection_string = ConfigurationManager.ConnectionStrings["DB_CONNECTION_STRING"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connection_string)) {
                conn.Open();
                string query = "select * from customer_cars where return_date is null and car_id = @car_num";
                try { 
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@car_num", car_num);
                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    { 
                      label11.Visible = false;
                      dateTimePicker1.Visible = false;
                      return true;
                    }
                }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message)
;                }
            }
            return false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string car_number = textBox1.Text.Trim();
            string maker = textBox2.Text.Trim();
            string model = textBox3.Text.Trim();
            string color = textBox4.Text.Trim();
            string engine_number = textBox5.Text.Trim();
            //string status = textBox8.Text.Trim();
            string chassis_number = textBox9.Text.Trim();

            string status = "Available";

            if (radioButton2.Checked)
            {
                status = "Not " + status;
            }

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
            string connection_string = ConfigurationManager.ConnectionStrings["DB_CONNECTION_STRING"].ConnectionString;

            string query = "UPDATE cars SET " +
                    "maker = @maker, " +
                    "model = @model, " +
                    "engine_number = @engine_number, " +
                    "chassis_number = @chassis_number, " +
                    "color = @color, " +
                    "status = @status, " +
                    "car_number = @car_id " +
                    "WHERE car_number = @car_number";

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                {

                        // Add parameters to the command
                        command.Parameters.AddWithValue("@car_id", car_number);
                    command.Parameters.AddWithValue("@car_number", this.car_id);
                    command.Parameters.AddWithValue("@maker", maker);
                    command.Parameters.AddWithValue("@model", model);
                    command.Parameters.AddWithValue("@engine_number", engine_number);
                    command.Parameters.AddWithValue("@chassis_number", chassis_number);
                    command.Parameters.AddWithValue("@color", color);
                    command.Parameters.AddWithValue("@status", status);

                   
                        // Open the connection and execute the command
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            MessageBox.Show("Data inserted successfully.");
                   
                }

                    query = @"
                            update customer_cars
                            set car_id = @car_id
                            where car_id = @car_num
                            ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@car_id", car_number);
                        command.Parameters.AddWithValue("@car_num", this.car_id);
                        command.ExecuteNonQuery();
                    }

                if (isRented == false && radioButton1.Checked == true) {
                    query = @"
                            update customer_cars
                            set return_date = @return_date
                            where return_date is null and car_id = @car_num   
                            ";

                    using (SqlCommand command = new SqlCommand(query, connection)) {

                        DateTime return_date = dateTimePicker1.Value;
                        string ret_date = return_date.ToString("yyyy-MM-dd hh:mm tt");

                        command.Parameters.AddWithValue("@return_date", ret_date);
                        command.Parameters.AddWithValue("@car_num", car_number);

                        command.ExecuteNonQuery();
                    }
                }
                }
                    catch (Exception ex)
                    {
                    // Handle exceptions
                    MessageBox.Show("An error occurred: " + ex.Message);
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

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
