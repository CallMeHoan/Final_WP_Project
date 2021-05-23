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
    public partial class ClickSchdule_Schedule_ : Form
    {
        public ClickSchdule_Schedule_()
        {
            InitializeComponent();
            save_btn.BackColor = Color.FromArgb(48, 182, 251);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
