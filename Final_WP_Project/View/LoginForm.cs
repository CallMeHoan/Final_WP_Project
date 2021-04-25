using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_WP_Project.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Style();
        }

        private void userName_txt_Enter(object sender, EventArgs e)
        {
            if(userName_txt.Text== "Username")
            {
                userName_txt.Text = "";
            }    
        }

        private void userName_txt_Leave(object sender, EventArgs e)
        {
            if(userName_txt.Text == "")
            {
                userName_txt.Text = "Username";
                userName_txt.ForeColor = Color.FromArgb(48, 182, 251);
            }
        }

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
                password_txt.ForeColor = Color.FromArgb(48, 182, 251);
            }
        }

        public void Style()
        {
            this.label2.ForeColor = Color.FromArgb(48, 182, 251);
            this.yourAre_lb.ForeColor = Color.FromArgb(48, 182, 251);
            this.userName_txt.ForeColor = Color.FromArgb(48, 182, 251);
            this.password_txt.ForeColor = Color.FromArgb(48, 182, 251);
            this.submit_btn.BackColor = Color.FromArgb(48, 182, 251);
            submit_btn.TabStop = false;
            submit_btn.FlatStyle = FlatStyle.Flat;
            submit_btn.FlatAppearance.BorderSize = 0;
        }
    }
}
