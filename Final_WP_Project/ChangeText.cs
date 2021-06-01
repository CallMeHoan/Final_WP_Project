using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_WP_Project
{
    public partial class ChangeText : Form
    {
        public ChangeText()
        {
            InitializeComponent();
        }

        private void ChangeText_Load(object sender, EventArgs e)
        {
            textBox1.Text = Global.s1;
            textBox2.Text = Global.s2;
            textBox3.Text = Global.s3;
            textBox4.Text = Global.s4;
            textBox5.Text = Global.s5;
            textBox6.Text = Global.s6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.s1a(textBox1.Text);
            Global.s2a(textBox2.Text);
            Global.s3a(textBox3.Text);
            Global.s4a(textBox4.Text);
            Global.s5a(textBox5.Text);
            Global.s6a(textBox6.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
