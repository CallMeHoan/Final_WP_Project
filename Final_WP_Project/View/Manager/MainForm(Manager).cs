
using Final_WP_Project.View.Manager;
using Final_WP_Project.View.Manager.Employee_click;
using Final_WP_Project.View.Reception;
using Final_WP_Project.View.Reception.Schedule;
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

        private void main_pn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reception_btn_Click(object sender, EventArgs e)
        {
            ReceptionClickForm_Manager_ f = new ReceptionClickForm_Manager_();
            f.Show();
        }

        private void MainForm_Manager__Load(object sender, EventArgs e)
        {
            lb_welcome.Text = "Welcome " + Global.GlobalId;
           timer1.Enabled = true;
            timer1.Start();

        }

        private void schedule_btn_Click(object sender, EventArgs e)
        {
            Schedule f = new Schedule();
            f.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Global.GetDay(d.ToString());
            Global.GetHour(h.ToString());
            Global.GetMinute(m.ToString());
           
            Main f = new Main();
            f.Show();
        }

        private void btn_attendace_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        int h = DateTime.Now.Hour;
        int m = DateTime.Now.Minute;
        int d = 2;
        string w = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            m++;
            if(d==2)
            {
                w = "Monday";
            }
            if (d == 3)
            {
                w = "Tuesday";
            }
            if (d == 4)
            {
                w = "Wednesday";
            }
            if (d == 5)
            {
                w = "Friday";
            }
            if (d == 7)
            {
                w = "Saturday";
            }
            if (d == 8)
            {
                w = "Sunday";
            }
            if (m > 59)
            {
                m = 0;
                h++;
                lb_hour.Text = h.ToString();
                lb_minute.Text = m.ToString();
                lb_dow.Text = w;
            }
          
            if (h > 23)
            {
                h = 0;
                d++;
                lb_hour.Text = h.ToString();
                lb_minute.Text = m.ToString();
                lb_dow.Text = w;
            }
            if (d > 8)
            {
                d = 1;
                lb_hour.Text = h.ToString();
                lb_minute.Text = m.ToString();
                lb_dow.Text = w;
            }
            else
            {
                lb_hour.Text = h.ToString();
                lb_minute.Text = m.ToString();
                lb_dow.Text = w;
            }
            lb_hour.Text = h.ToString();
            lb_minute.Text = m.ToString();
            lb_dow.Text = w;
        }

        private void report_btn_Click(object sender, EventArgs e)
        {

        }

        private void employee_btn_Click(object sender, EventArgs e)
        {
            //EmployeeClick f = new EmployeeClick();
            RoomMain f = new RoomMain();
            f.Show();
        }

        private void room_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            MessageBox.Show("qưer");
        }
    }
}
