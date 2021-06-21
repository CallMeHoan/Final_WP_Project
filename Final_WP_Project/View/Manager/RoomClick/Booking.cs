using Final_WP_Project.Model;
using Final_WP_Project.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        MY_DB mydb = new MY_DB();
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
            string CusID = cusID_cb.Text;
            string name = cusName_cb.Text;
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
                
                if ( room.NewCustomer(CusID, name, phone, cmnd) == true && room.Booking(EmpID, RoomID, CusID, StartTime, EndTime, formatdate, state) == true)
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
                || (cusID_cb.Text.Trim() == "")
                || (cusName_cb.Text.Trim() == "")
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

        private void Booking_Load(object sender, EventArgs e)
        {
            Human h = new Human();
            roomID_txt.Text = Global.RoomID;
            SqlCommand cmd = new SqlCommand("Select id from Login where Account = '"+ Global.GlobalId +"'");
            DataTable dt = h.gethummans(cmd);
            empID_txt.Text = dt.Rows[0][0].ToString();


            SqlCommand loaddata = new SqlCommand("Select CustomerID, Name from Customer");
            DataTable dtt = h.gethummans(loaddata);
            for (int i = 0; i < dtt.Rows.Count; i++)
            {
                cusID_cb.Items.Add(dtt.Rows[i][0]);
                cusName_cb.Items.Add(dtt.Rows[i][1]);
            }

        }

        private void cusID_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load data
            Human h = new Human();
            string cmd = "Select Name, Phone, CMND from Customer where CustomerID = '" + cusID_cb.Text + "'";
            SqlCommand command = new SqlCommand(cmd, mydb.getConnection);
            DataTable dt = new DataTable();
            dt = h.gethummans(command);

            cusName_cb.Text = dt.Rows[0][0].ToString();
            phone_txt.Text = dt.Rows[0][1].ToString();
            cmnd_txt.Text = dt.Rows[0][2].ToString();

        }

        private void cusName_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load data
            Human h = new Human();
            string cmd = "Select CustomerID, Phone, CMND from Customer where Name ='" + cusName_cb.Text + "'";
            SqlCommand command = new SqlCommand(cmd, mydb.getConnection);
            DataTable dt = new DataTable();
            dt = h.gethummans(command);

            cusID_cb.Text = dt.Rows[0][0].ToString();
            phone_txt.Text = dt.Rows[0][1].ToString();
            cmnd_txt.Text = dt.Rows[0][2].ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
