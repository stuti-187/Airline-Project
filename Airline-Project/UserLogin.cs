using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Project
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AirlinedbEntities db = new AirlinedbEntities();
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                var user = db.Customers.Where(a => a.username.Equals(textBox1.Text)).SingleOrDefault();
                if (user != null)
                {
                    if (user.password.Equals(textBox2.Text))
                    {
                        TicketReservation ticketReservation = new TicketReservation();
                        ticketReservation.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password!");
                    }
                }
                else
                {
                    MessageBox.Show("No such user found!");
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new customerDetails().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
    }
}
