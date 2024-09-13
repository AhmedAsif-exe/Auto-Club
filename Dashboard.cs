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
            car.FormClosed += (s, args) => this.Show();
            car.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cars cars = new cars();
            cars.FormClosed += (s, args) => this.Show();
            cars.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Rent_History rent = new Rent_History();
            rent.FormClosed += (s, args) => this.Show();
            rent.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer_search customer = new customer_search();
            customer.FormClosed += (s, args) => this.Show();
            customer.Show();
            this.Hide();
        }
    }
}
