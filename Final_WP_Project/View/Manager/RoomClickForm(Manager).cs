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
    public partial class RoomClickForm_Manager_ : Form
    {
        public RoomClickForm_Manager_()
        {
            InitializeComponent();
            Style();
        }


        #region style
        public void Style()
        {
            //Color for label
            this.label2.ForeColor = Color.FromArgb(48, 182, 251);
            this.label14.ForeColor = Color.FromArgb(48, 182, 251);
            this.label15.ForeColor = Color.FromArgb(48, 182, 251);

            //color room label

            this.room1_lb.ForeColor = Color.FromArgb(48, 182, 251);
            this.room2_lb.ForeColor = Color.FromArgb(48, 182, 251);
            this.room3_lb.ForeColor = Color.FromArgb(48, 182, 251);
            this.room4_lb.ForeColor = Color.FromArgb(48, 182, 251);

            //color day label
            this.label16.ForeColor = Color.FromArgb(48, 182, 251);
            this.label17.ForeColor = Color.FromArgb(48, 182, 251);
            this.label18.ForeColor = Color.FromArgb(48, 182, 251);
            this.label19.ForeColor = Color.FromArgb(48, 182, 251);
            this.label20.ForeColor = Color.FromArgb(48, 182, 251);
            this.label21.ForeColor = Color.FromArgb(48, 182, 251);
            this.label22.ForeColor = Color.FromArgb(48, 182, 251);

            //color date label

            this.date1_lb.ForeColor = Color.FromArgb(48, 182, 251);
            this.date2_lb.ForeColor = Color.FromArgb(48, 182, 251);
            this.date3_lb.ForeColor = Color.FromArgb(48, 182, 251);
            this.date4_lb.ForeColor = Color.FromArgb(48, 182, 251);
            this.date5_lb.ForeColor = Color.FromArgb(48, 182, 251);
            this.date6_lb.ForeColor = Color.FromArgb(48, 182, 251);
            this.date7_lb.ForeColor = Color.FromArgb(48, 182, 251);

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
