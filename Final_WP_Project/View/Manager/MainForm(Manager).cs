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
    public partial class MainForm_Manager_ : Form
    {
        public MainForm_Manager_()
        {
            InitializeComponent();
            Style();
        }

        #region style
        public void Style()
        {
            //Color for label
            this.label2.ForeColor = Color.FromArgb(48, 182, 251);

            //no border button
            NoBorderButton(reception_btn);
            NoBorderButton(employee_btn);
            NoBorderButton(room_btn);
            NoBorderButton(schedule_btn);
            NoBorderButton(report_btn);
            
        }    
        public void NoBorderButton(Button a)
        {
            a.TabStop = false;
            a.FlatStyle = FlatStyle.Flat;
            a.FlatAppearance.BorderSize = 0;
        }
        #endregion
    }
}
