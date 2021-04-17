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
    public partial class Form2 : Form
    {
        AirlinedbEntities db;
        public DateTimePicker dt;
        public Form2()
        {
            InitializeComponent();
            db = new AirlinedbEntities();
            dt = new DateTimePicker();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool WithErrors()
        {
            if (textBox1.Text.Trim() == String.Empty)
                return true; // Returns true if no input or only space is found
            if (nametxt.Text.Trim() == String.Empty)
                return true;
            if (textBox3.Text.Trim()==String.Empty)
                return true;
            if (textBox4.Text.Trim() == String.Empty)
                return true;
            if (textBox5.Text.Trim() == String.Empty)
                return true;
            if (textBox6.Text.Trim() == String.Empty)
                return true;
            if (textBox7.Text.Trim() == String.Empty)
                return true;
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (WithErrors())
            {
                MessageBox.Show("Missing fields!");
            }
            else
            {
                Bookings booking = new Bookings();
                booking.Name = nametxt.Text;
                booking.Birth_date = dateTimePicker1.Value;
                booking.Date_of_Journey = dt.Value;
                booking.Email = textBox3.Text;
                booking.Phone_Number = textBox4.Text;
                booking.Address = textBox5.Text;
                booking.Flight_Id = Convert.ToInt32(textBox6.Text);
                booking.Flight_Name = textBox7.Text;
                booking.Seat_Number = textBox1.Text;
                db.Bookings1.Add(booking);
                db.SaveChanges();
                MessageBox.Show("Ticket Booked!");
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dt.Location = new Point(282, 337);
            dt.Size = new Size(301, 23);
            dt.MaxDate = new DateTime(2500, 12, 20);
            dt.MinDate = DateTime.Now;
            dt.Format = DateTimePickerFormat.Long;
            dt.Name = "MyPicker";
            dt.Font = new Font("Microsoft Sans Serif", 10);
            dt.Visible = true;

            this.Controls.Add(dt);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3(this).Show();
        }
    }
}
