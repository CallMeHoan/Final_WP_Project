using Final_WP_Project.View.Reception;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_WP_Project.View.Manager.Employee_click
{
    public partial class SalaryCompute : Form
    {
        public SalaryCompute()
        {
            InitializeComponent();
            Style();
        }
        string id;
        public SalaryCompute(string id)
        {
            this.id = id;
            InitializeComponent();
            Style();
        }
        #region style
        public void Style()
        {
            //Color for label
            this.label2.ForeColor = Color.FromArgb(48, 182, 251);
            this.label3.ForeColor = Color.FromArgb(48, 182, 251);
            this.label4.ForeColor = Color.FromArgb(48, 182, 251);


            //no border button
            NoBorderButton(reception_btn);
            NoBorderButton(employee_btn);
            NoBorderButton(room_btn);
            NoBorderButton(schedule_btn);
            NoBorderButton(report_btn);
            NoBorderButton(static_btn);

        }
        public void NoBorderButton(Button a)
        {
            a.TabStop = false;
            a.FlatStyle = FlatStyle.Flat;
            a.FlatAppearance.BorderSize = 0;
        }
        #endregion

        private void printPaycheck_btn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SalaryCompute_Load(object sender, EventArgs e)
        {
            if (Global.isManager == false)
            {
                reception_btn.Visible = false;
                static_btn.Visible = false;
            }
            SqlCommand command = new SqlCommand("Select name, age, phone, salary from employee where id = @id");
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            Human h = new Human();
            DataTable table = h.gethummans(command);
            id_lb.Text = id;
            name_lb.Text = table.Rows[0][0].ToString();
            age_lb.Text = table.Rows[0][1].ToString();
            baseSalary_lb.Text = table.Rows[0][3].ToString();
            phone_lb.Text = table.Rows[0][2].ToString();
            
        }

        private void cbb_Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            Human h = new Human();
            int day=2;
            if(cbb_Day.Text == "Monday")
            {
                day = 2;
            }
            if (cbb_Day.Text == "Tuesday")
            {
                day = 3;
            }
            if (cbb_Day.Text == "Wednesday")
            {
                day = 4;
            }
            if (cbb_Day.Text == "Thursday")
            {
                day = 5;
            }
            if (cbb_Day.Text == "Friday")
            {
                day = 6;

            }
            if (cbb_Day.Text == "Saturday")
            {
                day = 7;
            }
            if (cbb_Day.Text == "Sunday")
            {
                day = 8;
            }
            string[] attendance = h.GetSalaryDay(Convert.ToInt32(id), day);
            int absent=0;
            int present=0;
            int late=0;
            int presentc = 0;
            for(int i = 0; i < attendance.Length; i++)
            {
                if(attendance[i]=="Present")
                {
                    present++;
                    if(day==8)
                    {
                        presentc++;
                    }
                }
                if(attendance[i]=="Absent")
                {
                    absent++;
                }
                if(attendance[i]=="Late")
                {
                    late++;
                }
            }
            Late_lb.Text = late.ToString() ;
            absent_lb.Text = absent.ToString();
            NoOfShift_lb.Text = (present+absent+late).ToString() + " Shift";
            SqlCommand command1 = new SqlCommand("Select salary from employee where id = @id ");
            command1.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            DataTable table1 = h.gethummans(command1);
            deduction_lb.Text = "-" + ((late * Global.LateSalary).ToString());
            totalSalary_lb.Text = (Convert.ToInt32(table1.Rows[0][0])*2*presentc+(present + late) * Convert.ToInt32(table1.Rows[0][0]) - (late * Global.LateSalary)).ToString();
            baseSalary_lb.Text = table1.Rows[0][0].ToString();
            present_lb.Text = present.ToString() ;
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            Close();
            ReportClick f = new ReportClick();
            f.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {

        }
        private void reception_btn_Click(object sender, EventArgs e)
        {
            Close();
            ReceptionClickForm_Manager_ f = new ReceptionClickForm_Manager_();
            f.Show();
        }

        private void employee_btn_Click(object sender, EventArgs e)
        {
            Close();
            EmployeeClick f = new EmployeeClick();
            f.Show();
        }

        private void room_btn_Click(object sender, EventArgs e)
        {
            Close();
            RoomMain f = new RoomMain();
            f.Show();
        }

        private void static_btn_Click(object sender, EventArgs e)
        {
            DayOff f = new DayOff();
            f.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
