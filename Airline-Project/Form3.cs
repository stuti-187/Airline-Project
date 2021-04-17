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

namespace Airline_Project
{
    
    public partial class Form3 : Form
    {
        public String seat;
        Form2 form;
        AirlinedbEntities db;
        public Form3(Form2 form2)
        {
            InitializeComponent();
            seat = "";
            form = form2;
            db = new AirlinedbEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RadioButton radioButton = new RadioButton();
            foreach (RadioButton rb in groupBox1.Controls.OfType<RadioButton>())
            {
                String seatId = "";
                if (rb.Checked)
                {
                    radioButton = rb;
                    seatId = rb.Name.ToString();
                    seat = seatId.Substring(seatId.Length - 2);

                }
            }

            FlightSeatDetil flightSeatDetil = new FlightSeatDetil();
            flightSeatDetil.FlightName = form.textBox7.Text;
            flightSeatDetil.FlightNumber = Convert.ToInt32(form.textBox6.Text);
            String y = form.dt.Value.Year.ToString();
            String d = form.dt.Value.Day.ToString();
            String m = form.dt.Value.Month.ToString();
            String con = d + m + y;
            flightSeatDetil.FlightDate = con;
            flightSeatDetil.SeatNumber = radioButton.Name;
            db.FlightSeatDetils.Add(flightSeatDetil);
            db.SaveChanges();

            form.textBox1.Text = seat;
            
            this.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //List<FlightSeatDetil> flightSeats = db.FlightSeatDetils.ToList();
            String y = form.dt.Value.Year.ToString();
            String d = form.dt.Value.Day.ToString();
            String m = form.dt.Value.Month.ToString();
            String concat = d + m + y;
            List<String> seatList = new List<String>();
            String connString = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = Airlinedb; Integrated Security = True; Pooling = False; MultipleActiveResultSets = True; Application Name = EntityFramework";
            String seatsConcat = "";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM FlightSeatDetils where FlightNumber=@fNumber and FlightDate=@fDate ", conn);
                cmd.Parameters.AddWithValue("@fNumber", form.textBox6.Text);
                cmd.Parameters.AddWithValue("@fDate", concat);
                try
                {
                    conn.Open();
                    using (SqlDataReader oReader = cmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                           seatList.Add(oReader["SeatNumber"].ToString());
                        }
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            foreach (string s in seatList)
            {
                foreach (RadioButton rb in groupBox1.Controls.OfType<RadioButton>())
                {
                    if(s.Equals(rb.Name))
                    {
                        Point p = new Point((int)rb.Location.X, (int)rb.Location.Y);
                        TextBox tb = new TextBox();
                        tb.Location = p;
                        tb.BackColor = SystemColors.ControlDarkDark;
                        tb.Height = 22;
                        tb.Width = 22;
                        tb.Enabled = false;
                        rb.Visible = false;
                        groupBox1.Controls.Add(tb);
                    }
                }
            }
            
        }
    }
}
