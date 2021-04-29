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
    public partial class ClickNext_Manage_ : Form
    {
        public ClickNext_Manage_()
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
            this.label7.ForeColor = Color.FromArgb(48, 182, 251);


            //color for textbox
            this.userName_txt.ForeColor = Color.FromArgb(130, 130, 130);
            this.password_txt.ForeColor = Color.FromArgb(130, 130, 130);
            this.confirm_txt.ForeColor = Color.FromArgb(130, 130, 130);

            //Color for button

            //submit button
            this.submit_btn.BackColor = Color.FromArgb(48, 182, 251);
            this.submit_btn.ForeColor = Color.FromArgb(255, 255, 255);
            //Cancel button
            this.cancel_btn.BackColor = Color.FromArgb(48, 182, 251);
            this.cancel_btn.ForeColor = Color.FromArgb(255, 255, 255);
            //previous button
            this.previous_btn.BackColor = Color.FromArgb(48, 182, 251);
            this.previous_btn.ForeColor = Color.FromArgb(255, 255, 255);

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

        // username
        private void userName_txt_Enter(object sender, EventArgs e)
        {
            if (userName_txt.Text == "User name")
            {
                userName_txt.Text = "";
            }
        }

        private void userName_txt_Leave(object sender, EventArgs e)
        {
            if (userName_txt.Text == "")
            {
                userName_txt.Text = "User name";
                userName_txt.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }
        //password
        private void password_txt_Enter(object sender, EventArgs e)
        {
            if (password_txt.Text == "Password")
            {
                password_txt.Text = "";
            }
        }

        private void password_txt_Leave(object sender, EventArgs e)
        {
            if (password_txt.Text == "")
            {
                password_txt.Text = "Password";
                userName_txt.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }

        private void confirm_txt_Enter(object sender, EventArgs e)
        {
            if (confirm_txt.Text == "Confirm password")
            {
                confirm_txt.Text = "";
            }
        }

        private void confirm_txt_Leave(object sender, EventArgs e)
        {

        }

        #endregion


    }
}
