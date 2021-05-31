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

namespace Final_WP_Project.View.Reception.RoomClick
{
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
            save_btn.BackColor = Color.FromArgb(48, 182, 251);

        }

        private void Status_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'viduDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.viduDataSet.Room);

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
    }
}

