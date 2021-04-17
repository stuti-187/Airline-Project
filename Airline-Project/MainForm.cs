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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addFlightInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flight flight = new Flight();
            flight.MdiParent = this;
            flight.Show();
        }

        private void addNewAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.MdiParent = this; 
            form.Show();
        }
    }
}
