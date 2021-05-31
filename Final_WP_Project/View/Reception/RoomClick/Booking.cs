using Final_WP_Project.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_WP_Project.View.Reception.Room
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
            next_btn.BackColor = Color.FromArgb(48, 182, 251);
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            RoomFunction room = new RoomFunction();
            string EmpID = empID_txt.Text;
            string RoomID = roomID_txt.Text;
            string CusID = cusID_txt.Text;
            string name = cusName_txt.Text;
            string phone = phone_txt.Text;
            string cmnd = cmnd_txt.Text;
            string start = start_dtp.Text;
            string end = end_dtp.Text;
            string date = date_dtp.Text;
            string state = "Booked";
            //Take date
            CultureInfo culture = new CultureInfo("es-ES");
            DateTime newdate = DateTime.Parse(date, culture);
            string formatdate = newdate.ToString("yyyy-MM-dd");

            //Take time
            DateTime dt;
            if (!DateTime.TryParseExact(start, "HH:mm:ss", CultureInfo.InvariantCulture,DateTimeStyles.None, out dt))
            {
                // handle validation error
            }
            TimeSpan StartTime = dt.TimeOfDay;

            DateTime time;
            if (!DateTime.TryParseExact(end, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out time))
            {
                // handle validation error
            }
            TimeSpan EndTime = time.TimeOfDay;

            if (Verify())
            {
                
                if (room.Booking(EmpID, RoomID, CusID, StartTime, EndTime, formatdate, state) == true && room.NewCustomer(CusID, name, phone, cmnd) == true)
                {
                    MessageBox.Show("Booking succesfully!", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult dialogResult = MessageBox.Show("Do you want to order goods", "Service", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Close();
                        Service sv = new Service(RoomID, CusID);
                        sv.Show();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Close();
                    }

                }
                else
                {
                    MessageBox.Show("Error!", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public bool Verify()
        {
            if ((empID_txt.Text.Trim() == "")
                || (roomID_txt.Text.Trim() == "")
                || (cusID_txt.Text.Trim() == "")
                || (cusName_txt.Text.Trim() == "")
                || (phone_txt.Text.Trim() == "")
                || (cmnd_txt.Text.Trim() == "")
                || (date_dtp.Text.Trim() == "")
                || (start_dtp.Text.Trim() == "")
                || (end_dtp.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
