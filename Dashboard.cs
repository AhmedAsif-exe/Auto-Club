using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Club
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 car = new Form1();
            this.Hide();
            car.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cars cars = new cars();
            this.Hide();
            cars.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rent_History rent = new Rent_History();
            this.Hide();
            rent.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer_search customer = new customer_search();
            this.Hide();
            customer.Show();
        }
    }
}
