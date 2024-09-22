using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Club
{
    public partial class Customer : Form
    {
        string car_num;
        int id = -1;
        public Customer(string car_num)
        {
            InitializeComponent();
            this.car_num = car_num;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 form = new Form1();
            //form.Show();
            this.Close();
        }
        void save_customer()
        {

            try
            {

                string connection_string = ConfigurationManager.ConnectionStrings["DB_CONNECTION_STRING"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connection_string))
                {
                    conn.Open();
                    string query = @"INSERT INTO customers 
                            (name, parent_name, cnic, phone_number, phone_residence, current_residence,
                             guarantor_name, guarantor_parent_name, guarantor_cnic, guarantor_phone_number, 
                             guarantor_phone_residence, guarantor_current_residence)
                         VALUES 
                            (@name, @parent_name, @cnic, @phone_number, @phone_residence, @current_residence, 
                             @guarantor_name, @guarantor_parent_name, @guarantor_cnic, @guarantor_phone_number, 
                             @guarantor_phone_residence, @guarantor_current_residence)
                            SELECT SCOPE_IDENTITY();
                            ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", string.IsNullOrEmpty(name.Text.Trim()) ? (object)DBNull.Value : name.Text.Trim());
                        cmd.Parameters.AddWithValue("@parent_name", string.IsNullOrEmpty(parent_name.Text.Trim()) ? (object)DBNull.Value : parent_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@cnic", string.IsNullOrEmpty(cnic.Text.Trim()) ? (object)DBNull.Value : cnic.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone_number", string.IsNullOrEmpty(phone_num.Text.Trim()) ? (object)DBNull.Value : phone_num.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone_residence", string.IsNullOrEmpty(phone_address.Text.Trim()) ? (object)DBNull.Value : phone_address.Text.Trim());
                        cmd.Parameters.AddWithValue("@current_residence", string.IsNullOrEmpty(curr_address.Text.Trim()) ? (object)DBNull.Value : curr_address.Text.Trim());

                        cmd.Parameters.AddWithValue("@guarantor_name", string.IsNullOrEmpty(g_name.Text.Trim()) ? (object)DBNull.Value : g_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@guarantor_parent_name", string.IsNullOrEmpty(g_parent_name.Text.Trim()) ? (object)DBNull.Value : g_parent_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@guarantor_cnic", string.IsNullOrEmpty(g_cnic.Text.Trim()) ? (object)DBNull.Value : g_cnic.Text.Trim());
                        cmd.Parameters.AddWithValue("@guarantor_phone_number", string.IsNullOrEmpty(g_num.Text.Trim()) ? (object)DBNull.Value : g_num.Text.Trim());
                        cmd.Parameters.AddWithValue("@guarantor_phone_residence", string.IsNullOrEmpty(g_phone_address.Text.Trim()) ? (object)DBNull.Value : g_phone_address.Text.Trim());
                        cmd.Parameters.AddWithValue("@guarantor_current_residence", string.IsNullOrEmpty(g_current_address.Text.Trim()) ? (object)DBNull.Value : g_current_address.Text.Trim());

                        object result = cmd.ExecuteScalar();
                        id = Convert.ToInt32(result);
                        MessageBox.Show("Customer data inserted successfully.");
                    }
                }

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    handle_duplicated_key_error();
                else
                    MessageBox.Show(TranslateSqlException(ex));
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            save_customer();
            if (id == -1) return;
            try
            {
                RentSummary rentSummary = new RentSummary(car_num, id);
                rentSummary.FormClosed += (s, args) => this.Close();
                this.Hide();
                rentSummary.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        void handle_duplicated_key_error()
        {
            string name = "";
            int customer_id = 0;

            string connection_string = ConfigurationManager.ConnectionStrings["DB_CONNECTION_STRING"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();
                string Cnic = cnic.Text.Trim();
                string query = @"
                                SELECT customer_id, name 
                                FROM customers
                                WHERE cnic = @cnic
                                ";
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cnic", Cnic);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                name = reader["name"].ToString();
                                customer_id = Convert.ToInt32(reader["customer_id"].ToString());
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {

                    MessageBox.Show(TranslateSqlException(ex));

                }
            }
            DialogResult result = MessageBox.Show("The provided CNIC already exists in our records.\n Is this the same individual?\nName = " + name, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.id = customer_id;
            }

        }
        string TranslateSqlException(SqlException ex)
        {
            switch (ex.Number)
            {
                case 2627: // Unique constraint violation
                case 2601: // Duplicated key row error
                    return "A record with the same unique information already exists.";

                case 547: // Foreign key violation
                    return "You cannot delete this record because it's in use elsewhere.";

                case 515: // Cannot insert null into a column that doesn't allow nulls
                    return "Please make sure all required fields are filled in.";

                case -2: // SQL Timeout
                    return "The request took too long. Please try again later.";

                case 53: // Cannot connect to SQL Server
                    return "Could not connect to the database. Please check your network connection.";

                default: // Default error message
                    return "An unexpected database error occurred. Please try again.";
            }
        }

        private void curr_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_address_TextChanged(object sender, EventArgs e)
        {
        }

        private void phone_num_TextChanged(object sender, EventArgs e)
        {
        }

        private void cnic_TextChanged(object sender, EventArgs e)
        {
        }

        private void parent_name_TextChanged(object sender, EventArgs e)
        {
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void g_current_address_TextChanged(object sender, EventArgs e)
        {
        }

        private void g_phone_address_TextChanged(object sender, EventArgs e)
        {
        }

        private void g_num_TextChanged(object sender, EventArgs e)
        {
        }

        private void g_cnic_TextChanged(object sender, EventArgs e)
        {
        }

        private void g_parent_name_TextChanged(object sender, EventArgs e)
        {
        }

        private void g_name_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
