using Final_WP_Project.Model;
using Final_WP_Project.View.Manager;
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

namespace Final_WP_Project.View.Reception.Schedule
{
    public partial class Main : Form
    {
        public Main()
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
            //no border button
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
        #endregion
        Label[,] A = new Label[10, 10];
       
        private void Main_Load(object sender, EventArgs e)
        {
            if(Global.isManager==false)
            {
                button3.Visible = false;
            }
            int x0 = 333;
            int y0 = 219;
            int dx = 0;
            int dy = 0;
            try
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Label label = new Label();
                        label.AutoSize = true;
                        label.Text = Global.Schedule[i, j];
                        label.Location = new Point(x0 + dx, y0 + dy);
                        label.Font = new Font("Poppins", 8);
                        if (i <= 3 && j <= 5)
                        {
                            label.BackColor = Color.DeepSkyBlue;
                            label.BringToFront();
                            dx += 148;
                            A[i, j] = label;
                        }
                        else if (i > 3 && j <= 5)
                        {
                            label.BackColor = Color.DarkViolet;
                            label.BringToFront();
                            dx += 148;
                            A[i, j] = label;
                        }
                        else
                        {
                            label.BackColor = Color.Green;
                            label.BringToFront();
                            dx += 148;
                            A[i, j] = label;
                        }
                    }
                    dx = 0;
                    dy += 72;
                }// Khởi tạo mảng label
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        this.Controls.Add(A[i, j]);
                        A[i, j].BringToFront();

                    }

                } // Xuất mảng label
                timer1.Enabled = true;
                timer1.Start();
            }
            catch
            {
                MessageBox.Show("You must set your Schedule first", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }

        private void printPaycheck_btn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ca = "";
            Global.GetDay(d.ToString());
            Global.GetHour(h.ToString());
            Global.GetMinute(m.ToString());
          
            if(h==7&&m<30)
            {
                ca="1a";
            }
            if (h == 10 && m < 30)
            {
                ca = "2a";
            }
            if (h == 13 && m < 30)
            {
                ca = "3a";
            }
            if (h == 16 && m < 30)
            {
                ca = "4a";
            }
            if (h == 19 && m < 30)
            {
                ca = "5a";
            }
            if (h == 22 && m < 30)
            {
                ca = "6a";
            }
            if (h == 1 && m < 30)
            {
                ca = "7a";
            }
            if (h == 4 && m < 30)
            {
                ca = "8a";
            }

            if(h==9 && m>=30)
            {
                ca = "1b";
            }
            if (h == 12 && m >= 30)
            {
                ca = "2b";
            }
            if (h == 15 && m >= 30)
            {
                ca = "3b";
            }
            if (h == 18 && m >= 30)
            {
                ca = "4b";
            }
            if (h == 21 && m >= 30)
            {
                ca = "5b";
            }
            if (h == 0 && m >= 30)
            {
                ca = "6b";
            }
            if (h == 3 && m >= 30)
            {
                ca = "7b";
            }
            if (h == 6 && m >= 30)
            {
                ca = "8b";
            }
            
            if (ca != "")
            {
                ClickSchdule_Schedule_ f = new ClickSchdule_Schedule_(ca);
                f.Show();
            }
            else
            {
                MessageBox.Show("You too late, today you are absent", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        int h = Convert.ToInt32(Global.Hour);
        int m = Convert.ToInt32(Global.Minute);
        int d = Convert.ToInt32(Global.Day);
        string w = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            m++;
            if (d == 2)
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
                w = "Thursday";
            }

            if (d == 6)
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
                d = 2;
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

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void lb_dow_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lb_hour_Click(object sender, EventArgs e)
        {
            h++;
            
        }

        private void lb_minute_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Workday");
            Human h = new Human();
            MY_DB db = new MY_DB();
             DataTable table =  h.gethummans(command);
            for(int i = 0; i < table.Rows.Count; i++)
            {

                if (i == 1 || i == 2 || i == 5 || i == 8 || i == 11 || i == 99 || i == 4 || i == 12 || i == 33)
                {
                    SqlCommand command1 = new SqlCommand("UPDATE WorkDay SET Attendance = 'Late' WHERE IDShift = " + i + ";", db.getConnection);
                    h.gethummans(command1);


                }
                else if (i == 3 || i == 88 || i == 67 || i == 32 || i == 44)
                {
                    SqlCommand command1 = new SqlCommand("UPDATE WorkDay SET Attendance = 'Absent' WHERE IDShift = " + i + ";", db.getConnection);
                    h.gethummans(command1);
                    db.openConnection();

                }
                else
                {
                    SqlCommand command1 = new SqlCommand("UPDATE WorkDay SET Attendance = 'Present' WHERE IDShift = " + i + ";", db.getConnection);
                    h.gethummans(command1);
                   
                }
                
            }
            MessageBox.Show("Simulated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DayOff f = new DayOff();
            f.Show();
        }
    }
}
