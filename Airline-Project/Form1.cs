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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AirlinedbEntities db = new AirlinedbEntities();
            if(usrtxt.Text != string.Empty && passtxt.Text != string.Empty)
            {
                var user = db.Admins.Where(a => a.Username.Equals(usrtxt.Text)).SingleOrDefault();
                if(user!=null)
                {
                    if(user.Password.Equals(passtxt.Text))
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Close();
                    } else
                    {
                        MessageBox.Show("Wrong Password!");
                    }
                } else
                {
                    MessageBox.Show("No such user found!");
                }
            } else
            {
                MessageBox.Show("Please enter username and password!");
            }
        }
    }
}
