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
    public partial class customer_edit : Form
    {
        int customer_id;
        public customer_edit(int customer_id)
        {
            InitializeComponent();
            this.customer_id = customer_id;
            get_data(customer_id);
        }
        void get_data(int customer_id)
        {
            string connection_string = "Data Source=PROGRAMMACHINE\\SQLEXPRESS;Initial Catalog=AutoClub;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                conn.Open();

                string query = "select * from customers where customer_id = @customer_id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customer_id", customer_id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                name.Text = (reader.IsDBNull(1) ? "N/A" : reader.GetString(1));
                                parent_name.Text = (reader.IsDBNull(2) ? "N/A" : reader.GetString(2));
                                cnic.Text = (reader.IsDBNull(3) ? "N/A" : reader.GetString(3));
                                phone_num.Text = (reader.IsDBNull(4) ? "N/A" : reader.GetString(4));
                                phone_address.Text = (reader.IsDBNull(5) ? "N/A" : reader.GetString(5));
                                curr_address.Text = (reader.IsDBNull(6) ? "N/A" : reader.GetString(6));
                                g_name.Text = (reader.IsDBNull(7) ? "N/A" : reader.GetString(7));
                                g_parent_name.Text = (reader.IsDBNull(8) ? "N/A" : reader.GetString(8));
                                g_cnic.Text = (reader.IsDBNull(9) ? "N/A" : reader.GetString(9));
                                g_num.Text = (reader.IsDBNull(10) ? "N/A" : reader.GetString(10));
                                g_phone_address.Text = (reader.IsDBNull(11) ? "N/A" : reader.GetString(11));
                                g_current_address.Text = (reader.IsDBNull(12) ? "N/A" : reader.GetString(12));
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
        void save_customer()
        {

            try
            {

                string connection_string = "Data Source=PROGRAMMACHINE\\SQLEXPRESS;Initial Catalog=AutoClub;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connection_string))
                {
                    conn.Open();
                    string query = @"UPDATE customers
                                    SET 
                                        name = @name,
                                        parent_name = @parent_name,
                                        phone_number = @phone_number,
                                        phone_residence = @phone_residence,
                                        current_residence = @current_residence,
                                        guarantor_name = @guarantor_name,
                                        guarantor_parent_name = @guarantor_parent_name,
                                        guarantor_cnic = @guarantor_cnic,
                                        guarantor_phone_number = @guarantor_phone_number,
                                        guarantor_phone_residence = @guarantor_phone_residence,
                                        guarantor_current_residence = @guarantor_current_residence
                                    WHERE 
                                        customer_id = @customer_id
                            ";
                    MessageBox.Show($"{name.Text.Trim()}");

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
                        cmd.Parameters.AddWithValue("@guarantor_cnic", string.IsNullOrEmpty(g_cnic.Text.Trim()) ? (object)DBNull.Value : cnic.Text.Trim());
                        cmd.Parameters.AddWithValue("@guarantor_phone_number", string.IsNullOrEmpty(g_num.Text.Trim()) ? (object)DBNull.Value : g_num.Text.Trim());
                        cmd.Parameters.AddWithValue("@guarantor_phone_residence", string.IsNullOrEmpty(g_phone_address.Text.Trim()) ? (object)DBNull.Value : g_phone_address.Text.Trim());
                        cmd.Parameters.AddWithValue("@guarantor_current_residence", string.IsNullOrEmpty(g_current_address.Text.Trim()) ? (object)DBNull.Value : g_current_address.Text.Trim());
                        cmd.Parameters.AddWithValue("@customer_id", this.customer_id);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer data inserted successfully.");
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(TranslateSqlException(ex));
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

        private void button3_Click(object sender, EventArgs e)
        {
            save_customer();
            //customer_search customer_Search = new customer_search();
            //customer_Search.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //customer_search customer_Search = new customer_search();
            //customer_Search.Show();
            this.Close();
        }
    }
}
