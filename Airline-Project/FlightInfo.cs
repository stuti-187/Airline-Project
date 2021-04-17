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
    public partial class Flight : Form
    {
        AirlinedbEntities db;
        public Flight()
        {
            InitializeComponent();
            db = new AirlinedbEntities();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flight_Details flight_Details = new Flight_Details();
            flight_Details.Flight_Name = flname_txt.Text;
            flight_Details.Source = src_txt.Text;
            flight_Details.Destination = dst_txt.Text;
            flight_Details.Arrival_Time = arrival_time.Text;
            flight_Details.Departure_Time = departure_time.Text;
            flight_Details.Cost = Convert.ToDecimal(cost_txt.Text);
            flight_Details.Seats = Convert.ToInt16(seats_txt.Text);
            flight_Details.Flight_Class = class_txt.Text;
            db.Flight_Details.Add(flight_Details);
            db.SaveChanges();
            MessageBox.Show("Flight Added");
            this.Close();
        }
    }
}
