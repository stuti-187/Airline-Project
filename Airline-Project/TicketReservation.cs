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
    public partial class TicketReservation : Form
    {
        AirlinedbEntities db;
        public TicketReservation()
        {
            InitializeComponent();
            db = new AirlinedbEntities();
            BindSource();
            BindDestination();
        }

        private void BindDestination()
        {
            var items = db.Flight_Details.ToList();
            var destinations = new List<String>();
            foreach (Flight_Details fd in items)
            {
                if (!destinations.Contains(fd.Destination))
                {
                    destinations.Add(fd.Destination);
                }
            }
            destinationCombo.DataSource = destinations;
        }

        private void BindSource()
        {
            var items = db.Flight_Details.ToList();
            var sources = new List<String>();
            foreach(Flight_Details fd in items)
            {
                if(!sources.Contains(fd.Source))
                {
                    sources.Add(fd.Source);
                }
            }
            sourceCombo.DataSource = sources;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TicketReservation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sourceCombo.Text != destinationCombo.Text)
            {
                dataGridView1.DataSource = db.Flight_Details.Where(a => a.Source.Equals(sourceCombo.Text) &&
                a.Destination.Equals(destinationCombo.Text)).ToList();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 form = new Form2();
            form.textBox6.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            form.textBox7.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form.ShowDialog();
        }
    }
}
