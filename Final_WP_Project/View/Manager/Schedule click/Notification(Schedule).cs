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
    public partial class Notification_Schedule_ : Form
    {
        public Notification_Schedule_()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ChangeText f = new ChangeText();
            f.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Notification_Schedule__Load(object sender, EventArgs e)
        {
            label2.Text = "- "+Global.s1;
            label3.Text = "- " + Global.s2;
            label4.Text = "- " + Global.s3;
            label5.Text = "- " + Global.s4;
            label6.Text = "- " + Global.s5;
            label7.Text = "- " + Global.s6;
        }
    }
}
