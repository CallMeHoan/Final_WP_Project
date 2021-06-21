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

namespace Final_WP_Project.View.Reception.RoomClick
{
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
            save_btn.BackColor = Color.FromArgb(48, 182, 251);

        }
        bool have = true;
        private void Status_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'viduDataSet.Room' table. You can move, or remove it, as needed.
        
            SqlCommand command = new SqlCommand("Select id from room");
            Human h = new Human();
            DataTable table = h.gethummans(command);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                id_cb.Items.Add(table.Rows[i][0].ToString());
            }

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            RoomFunction room = new RoomFunction();
            string id = id_cb.Text;
            string state = status_cb.Text;
            string date = date_dtp.Text;

            //take date
            CultureInfo culture = new CultureInfo("es-ES");
            string datetime = date;
            DateTime newdate = DateTime.Parse(datetime, culture);
            string formatdate = newdate.ToString("yyyy-MM-dd");

            if (state == "Available")
            {
                if (Verify())
                {

                    if (room.ChangeStatusToAvailable(formatdate, id))
                    {
                        MessageBox.Show("Change status succesfully!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty field", "Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                id_cb.Text = "";
                status_cb.Text = "";
                date_dtp.Text = "";
            }
            else
            {
                if (Verify())
                {

                    if (room.ChangeStatusToUnavailable(formatdate, id))
                    {
                        MessageBox.Show("Change status succesfully!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty field", "Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                id_cb.Text = "";
                status_cb.Text = "";
                date_dtp.Text = "";
            }
        }


        public bool Verify()
        {
            if ((id_cb.Text.Trim() == "")
                || (status_cb.Text.Trim() == "")
                || (date_dtp.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
   
        private void id_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            CultureInfo culture = new CultureInfo("es-ES");
            string datetime = date_dtp.Text;
            DateTime newdate = DateTime.Parse(datetime, culture);
            string formatdate = newdate.ToString("yyyy-MM-dd");
            //SqlCommand command = new SqlCommand("Select roomid from room");
           Human h = new Human();
            //DataTable table = h.gethummans(command);
            //if (have == false)
            //{
            //    for (int i = 0; i < table.Rows.Count; i++)
            //    {
            //        id_cb.Items.Add(table.Rows[i][0].ToString());

            //    }
            //}
          
            SqlCommand command1 = new SqlCommand("Select state from Booking where RoomID = @rid and Date = @date");
            command1.Parameters.Add("@rid", SqlDbType.NVarChar).Value = id_cb.Text;
            command1.Parameters.Add("@date", SqlDbType.NVarChar).Value = formatdate;
            DataTable table1 = h.gethummans(command1);
            if (table1.Rows.Count == 0)
            {
                status_cb.Text = "Available";
            }
            else
            {
                status_cb.Text = table1.Rows[0][0].ToString();
            }
            
        }
    }
}

