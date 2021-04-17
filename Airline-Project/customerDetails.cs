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
    public partial class customerDetails : Form
    {
        public customerDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cstmr_password_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AirlinedbEntities db = new AirlinedbEntities();
            Customer customer = new Customer
            {
                Name = name_txt.Text,
                Phone_ = phn_txt.Text,
                Birthday = birthdate_picker.Value,
                Address = addr_txt.Text,
                Email = email_txt.Text,
                username = usrnametxt.Text,
                password = passtxt.Text
            };
            db.Customers.Add(customer);
            db.SaveChanges();
            MessageBox.Show("User Registered");
            this.Close();
        }
    }
}
