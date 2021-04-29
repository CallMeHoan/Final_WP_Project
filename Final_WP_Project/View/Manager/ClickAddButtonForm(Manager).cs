using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_WP_Project.View.Manager
{
    public partial class ClickAddButtonForm_Manager_ : Form
    {
        public ClickAddButtonForm_Manager_()
        {
            InitializeComponent();
            Style();
        }
        #region style
        /*These are styling form function*/
        public void Style()
        {
            //Color for label
            this.label2.ForeColor = Color.FromArgb(48, 182, 251);
            this.label3.ForeColor = Color.FromArgb(48, 182, 251);
            this.label4.ForeColor = Color.FromArgb(130, 130, 130);
            this.label5.ForeColor = Color.FromArgb(130, 130, 130);
            this.label6.ForeColor = Color.FromArgb(130, 130, 130);


            //color for textbox
            this.receptionID_txt.ForeColor = Color.FromArgb(130, 130, 130);
            this.firstName_txt.ForeColor = Color.FromArgb(130, 130, 130);
            this.lastName_txt.ForeColor = Color.FromArgb(130, 130, 130);
            this.phone_txt.ForeColor = Color.FromArgb(130, 130, 130);

            //Color for button

            //save button
            this.next_btn.BackColor = Color.FromArgb(48, 182, 251);
            this.next_btn.ForeColor = Color.FromArgb(255, 255, 255);
            //Cancel button
            this.cancel_btn.BackColor = Color.FromArgb(48, 182, 251);
            this.cancel_btn.ForeColor = Color.FromArgb(255, 255, 255);

            //Color for text box
            this.receptionID_txt.BackColor = Color.FromArgb(228, 221, 221);
            this.firstName_txt.BackColor = Color.FromArgb(228, 221, 221);
            this.lastName_txt.BackColor = Color.FromArgb(228, 221, 221);
            this.phone_txt.BackColor = Color.FromArgb(228, 221, 221);

            //no border button
            NoBorderButton(reception_btn);
            NoBorderButton(employee_btn);
            NoBorderButton(room_btn);
            NoBorderButton(schedule_btn);
            NoBorderButton(report_btn);
        }

        //No border button
        public void NoBorderButton(Button a)
        {
            a.TabStop = false;
            a.FlatStyle = FlatStyle.Flat;
            a.FlatAppearance.BorderSize = 0;
        }

        //No border comboBox
        public void NoBorderComboBox(ComboBox a)
        {
            a.TabStop = false;
            a.FlatStyle = FlatStyle.Flat;
            a.FlatStyle = 0;
        }

        /*Create Placeholder for each textbox*/

        //Reception ID

        private void receptionID_txt_Enter_1(object sender, EventArgs e)
        {
            if (receptionID_txt.Text == "Reception ID")
            {
                receptionID_txt.Text = "";
            }
        }

        private void receptionID_txt_Leave_1(object sender, EventArgs e)
        {
            if (receptionID_txt.Text == "")
            {
                receptionID_txt.Text = "Reception ID";
                receptionID_txt.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }


        //First name


        private void firstName_txt_Enter_1(object sender, EventArgs e)
        {
            if (firstName_txt.Text == "First name")
            {
                firstName_txt.Text = "";
            }
        }

        private void firstName_txt_Leave_1(object sender, EventArgs e)
        {
            if (firstName_txt.Text == "")
            {
                firstName_txt.Text = "First name";
                firstName_txt.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }


        //Last name

        private void lastName_txt_Enter_1(object sender, EventArgs e)
        {
            if (lastName_txt.Text == "Last name")
            {
                lastName_txt.Text = "";
            }
        }

        private void lastName_txt_Leave_1(object sender, EventArgs e)
        {
            if (lastName_txt.Text == "")
            {
                lastName_txt.Text = "First name";
                lastName_txt.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }

        //Phone number

        private void phone_txt_Enter_1(object sender, EventArgs e)
        {
            if (phone_txt.Text == "Phone number")
            {
                phone_txt.Text = "";
            }
        }

        private void phone_txt_Leave_1(object sender, EventArgs e)
        {
            if (phone_txt.Text == "")
            {
                phone_txt.Text = "Phone number";
                phone_txt.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }
        //Date combo Box

        private void date_cb_Enter(object sender, EventArgs e)
        {
            if (date_cb.Text == "Date")
            {
                phone_txt.Text = "";
            }
        }

        private void date_cb_Leave(object sender, EventArgs e)
        {
            if (date_cb.Text == "")
            {
                date_cb.Text = "Date";
                date_cb.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }

        //Month combo Box

        private void month_cb_Enter(object sender, EventArgs e)
        {
            if (month_cb.Text == "Date")
            {
                month_cb.Text = "";
            }
        }

        private void month_cb_Leave(object sender, EventArgs e)
        {
            if (month_cb.Text == "")
            {
                month_cb.Text = "Date";
                month_cb.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }

        //year combo box
        private void year_cb_Enter(object sender, EventArgs e)
        {
            if (year_cb.Text == "Date")
            {
                year_cb.Text = "";
            }
        }

        private void year_cb_Leave(object sender, EventArgs e)
        {
            if (year_cb.Text == "")
            {
                year_cb.Text = "Date";
                year_cb.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }
        #endregion

    }
}
