﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Auto_Club
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connection_string = "Data Source=DESKTOP-MAO1OJ0\\SQLEXPRESS;Initial Catalog=AutoClub;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                string car_num = textBox1.Text.Trim();
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
                                maker.Text = "Maker: " + (reader.IsDBNull(1) ? "N/A" : reader.GetString(1));
                                model.Text = "Model: " + (reader.IsDBNull(2) ? "N/A" : reader.GetString(2));
                                engine.Text = "Engine Number: " + (reader.IsDBNull(3) ? "N/A" : reader.GetString(3));
                                chassis.Text = "Chassis Number: " + (reader.IsDBNull(4) ? "N/A" : reader.GetString(4));
                                color.Text = "Color: " + (reader.IsDBNull(5) ? "N/A" : reader.GetString(5));
                                status.Text = "Status: " + (reader.IsDBNull(6) ? "N/A" : reader.GetString(6));
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message);
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("No Results Found");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void color_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (status.Text.Trim() != "Status: Available")
            {
                MessageBox.Show("Car Not Available");
                return;
            }
            string car_num = textBox1.Text.Trim();
            Customer customer = new Customer(car_num);
            customer.Show();
            this.Hide();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
