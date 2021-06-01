using Final_WP_Project.Model;
using Final_WP_Project.View.Reception.Room;
using Final_WP_Project.View.Reception.RoomClick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_WP_Project.View.Reception
{
    public partial class RoomMain : Form
    {
        public RoomMain()
        {
            InitializeComponent();
            Style();
        }

        //Load add room
        private void Room_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT DISTINCT Floor FROM Room";
            LoadFloor(cmd);
            
            #region Load Day
            DateTime date = DateTime.Today;
            switch (date.DayOfWeek.ToString())
            {
                case "Monday":
                    {
                        date1_lb.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        date2_lb.Text = DateTime.Today.AddDays(1).ToString("dd/MM/yyyy");
                        date3_lb.Text = DateTime.Today.AddDays(2).ToString("dd/MM/yyyy");
                        date4_lb.Text = DateTime.Today.AddDays(3).ToString("dd/MM/yyyy");
                        date5_lb.Text = DateTime.Today.AddDays(4).ToString("dd/MM/yyyy");
                        date6_lb.Text = DateTime.Today.AddDays(5).ToString("dd/MM/yyyy");
                        date7_lb.Text = DateTime.Today.AddDays(6).ToString("dd/MM/yyyy");
                        fromdate_lb.Text = date1_lb.Text;
                        todate_lb.Text = date7_lb.Text;
                        break;
                    }
                case "Tuesday":
                    {
                        date1_lb.Text = DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy");
                        date2_lb.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        date3_lb.Text = DateTime.Today.AddDays(1).ToString("dd/MM/yyyy");
                        date4_lb.Text = DateTime.Today.AddDays(2).ToString("dd/MM/yyyy");
                        date5_lb.Text = DateTime.Today.AddDays(3).ToString("dd/MM/yyyy");
                        date6_lb.Text = DateTime.Today.AddDays(4).ToString("dd/MM/yyyy");
                        date7_lb.Text = DateTime.Today.AddDays(5).ToString("dd/MM/yyyy");
                        fromdate_lb.Text = date1_lb.Text;
                        todate_lb.Text = date7_lb.Text;
                        break;
                    }
                case "Wednesday":
                    {
                        date1_lb.Text = DateTime.Today.AddDays(-2).ToString("dd/MM/yyyy");
                        date2_lb.Text = DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy");
                        date3_lb.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        date4_lb.Text = DateTime.Today.AddDays(1).ToString("dd/MM/yyyy");
                        date5_lb.Text = DateTime.Today.AddDays(2).ToString("dd/MM/yyyy");
                        date6_lb.Text = DateTime.Today.AddDays(3).ToString("dd/MM/yyyy");
                        date7_lb.Text = DateTime.Today.AddDays(4).ToString("dd/MM/yyyy");
                        fromdate_lb.Text = date1_lb.Text;
                        todate_lb.Text = date7_lb.Text;
                        break;
                    }
                case "Thursday":
                    {
                        date1_lb.Text = DateTime.Today.AddDays(-3).ToString("dd/MM/yyyy");
                        date2_lb.Text = DateTime.Today.AddDays(-2).ToString("dd/MM/yyyy");
                        date3_lb.Text = DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy");
                        date4_lb.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        date5_lb.Text = DateTime.Today.AddDays(2).ToString("dd/MM/yyyy");
                        date6_lb.Text = DateTime.Today.AddDays(3).ToString("dd/MM/yyyy");
                        date7_lb.Text = DateTime.Today.AddDays(4).ToString("dd/MM/yyyy");
                        fromdate_lb.Text = date1_lb.Text;
                        todate_lb.Text = date7_lb.Text;
                        break;
                    }
                case "Friday":
                    {
                        date1_lb.Text = DateTime.Today.AddDays(-4).ToString("dd/MM/yyyy");
                        date2_lb.Text = DateTime.Today.AddDays(-3).ToString("dd/MM/yyyy");
                        date3_lb.Text = DateTime.Today.AddDays(-2).ToString("dd/MM/yyyy");
                        date4_lb.Text = DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy");
                        date5_lb.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        date6_lb.Text = DateTime.Today.AddDays(1).ToString("dd/MM/yyyy");
                        date7_lb.Text = DateTime.Today.AddDays(2).ToString("dd/MM/yyyy");
                        fromdate_lb.Text = date1_lb.Text;
                        todate_lb.Text = date7_lb.Text;
                        break;
                    }
                case "Saturday":
                    {
                        date1_lb.Text = DateTime.Today.AddDays(-5).ToString("dd/MM/yyyy");
                        date2_lb.Text = DateTime.Today.AddDays(-4).ToString("dd/MM/yyyy");
                        date3_lb.Text = DateTime.Today.AddDays(-3).ToString("dd/MM/yyyy");
                        date4_lb.Text = DateTime.Today.AddDays(-2).ToString("dd/MM/yyyy");
                        date5_lb.Text = DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy");
                        date6_lb.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        date7_lb.Text = DateTime.Today.AddDays(1).ToString("dd/MM/yyyy");
                        fromdate_lb.Text = date1_lb.Text;
                        todate_lb.Text = date7_lb.Text;
                        break;
                    }
                case "Sunday":
                    {
                        date1_lb.Text = DateTime.Today.AddDays(-6).ToString("dd/MM/yyyy");
                        date2_lb.Text = DateTime.Today.AddDays(-5).ToString("dd/MM/yyyy");
                        date3_lb.Text = DateTime.Today.AddDays(-4).ToString("dd/MM/yyyy");
                        date4_lb.Text = DateTime.Today.AddDays(-3).ToString("dd/MM/yyyy");
                        date5_lb.Text = DateTime.Today.AddDays(-2).ToString("dd/MM/yyyy");
                        date6_lb.Text = DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy");
                        date7_lb.Text = DateTime.Now.ToString("dd/MM/yyyy");
                        fromdate_lb.Text = date1_lb.Text;
                        todate_lb.Text = date7_lb.Text;
                        break;
                    }
            }
            #endregion
            #region load OverDate
            if(OverDate(date1_lb) < 0)
            {
                panel5.BackColor = Color.FromArgb(181, 34, 61);
                panel6.BackColor = Color.FromArgb(181, 34, 61);
                panel7.BackColor = Color.FromArgb(181, 34, 61);
                panel8.BackColor = Color.FromArgb(181, 34, 61);
            }
            if (OverDate(date2_lb) < 0)
            {
                panel9.BackColor = Color.FromArgb(181, 34, 61);
                panel10.BackColor = Color.FromArgb(181, 34, 61);
                panel11.BackColor = Color.FromArgb(181, 34, 61);
                panel12.BackColor = Color.FromArgb(181, 34, 61);
            }
            if (OverDate(date3_lb) < 0)
            {
                panel13.BackColor = Color.FromArgb(181, 34, 61);
                panel14.BackColor = Color.FromArgb(181, 34, 61);
                panel15.BackColor = Color.FromArgb(181, 34, 61);
                panel16.BackColor = Color.FromArgb(181, 34, 61);
            }
            if (OverDate(date4_lb) < 0)
            {
                panel17.BackColor = Color.FromArgb(181, 34, 61);
                panel18.BackColor = Color.FromArgb(181, 34, 61);
                panel19.BackColor = Color.FromArgb(181, 34, 61);
                panel20.BackColor = Color.FromArgb(181, 34, 61);
            }
            if (OverDate(date5_lb) < 0)
            {
                panel21.BackColor = Color.FromArgb(181, 34, 61);
                panel22.BackColor = Color.FromArgb(181, 34, 61);
                panel23.BackColor = Color.FromArgb(181, 34, 61);
                panel24.BackColor = Color.FromArgb(181, 34, 61);
            }
            if (OverDate(date6_lb) < 0)
            {
                panel25.BackColor = Color.FromArgb(181, 34, 61);
                panel26.BackColor = Color.FromArgb(181, 34, 61);
                panel27.BackColor = Color.FromArgb(181, 34, 61);
                panel28.BackColor = Color.FromArgb(181, 34, 61);
            }
            if (OverDate(date7_lb) < 0)
            {
                panel29.BackColor = Color.FromArgb(181, 34, 61);
                panel30.BackColor = Color.FromArgb(181, 34, 61);
                panel31.BackColor = Color.FromArgb(181, 34, 61);
                panel32.BackColor = Color.FromArgb(181, 34, 61);
            }
            #endregion
            #region Load Room information
            #region Monday
            if(panel5.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room1_lb, date1_lb) == "Booked")
                {
                    panel5.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room1_lb, date1_lb) == "Unavailable")
                {
                    panel5.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel5.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel6.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room2_lb, date1_lb) == "Booked")
                {
                    panel6.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room2_lb, date1_lb) == "Unavailable")
                {
                    panel6.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel6.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel7.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room3_lb, date1_lb) == "Booked")
                {
                    panel7.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room3_lb, date1_lb) == "Unavailable")
                {
                    panel7.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel7.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel8.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room4_lb, date1_lb) == "Booked")
                {
                    panel8.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room4_lb, date1_lb) == "Unavailable")
                {
                    panel8.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel8.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            #endregion
            #region Tuesday
            if (panel9.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room1_lb, date2_lb) == "Booked")
                {
                    panel9.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room1_lb, date2_lb) == "Unavailable")
                {
                    panel9.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel9.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel10.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room2_lb, date2_lb) == "Booked")
                {
                    panel10.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room2_lb, date2_lb) == "Unavailable")
                {
                    panel10.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel10.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel11.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room3_lb, date2_lb) == "Booked")
                {
                    panel11.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room3_lb, date2_lb) == "Unavailable")
                {
                    panel11.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel11.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel12.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room4_lb, date2_lb) == "Booked")
                {
                    panel12.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room4_lb, date2_lb) == "Unavailable")
                {
                    panel12.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel12.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            #endregion
            #region Wednesday
            if (panel13.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room1_lb, date3_lb) == "Booked")
                {
                    panel13.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room1_lb, date3_lb) == "Unavailable")
                {
                    panel13.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel13.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel14.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room2_lb, date3_lb) == "Booked")
                {
                    panel14.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room2_lb, date3_lb) == "Unavailable")
                {
                    panel14.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel14.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel15.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room3_lb, date3_lb) == "Booked")
                {
                    panel15.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room3_lb, date3_lb) == "Unavailable")
                {
                    panel15.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel15.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel16.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room4_lb, date3_lb) == "Booked")
                {
                    panel16.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room4_lb, date3_lb) == "Unavailable")
                {
                    panel16.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel16.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            #endregion
            #region Thursday
            if (panel17.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room1_lb, date4_lb) == "Booked")
                {
                    panel17.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room1_lb, date4_lb) == "Unavailable")
                {
                    panel17.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel17.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel18.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room2_lb, date4_lb) == "Booked")
                {
                    panel18.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room2_lb, date4_lb) == "Unavailable")
                {
                    panel18.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel18.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel19.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room3_lb, date4_lb) == "Booked")
                {
                    panel19.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room3_lb, date4_lb) == "Unavailable")
                {
                    panel19.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel19.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel20.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room4_lb, date4_lb) == "Booked")
                {
                    panel20.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room4_lb, date4_lb) == "Unavailable")
                {
                    panel20.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel20.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            #endregion
            #region Friday
            if (panel21.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room1_lb, date5_lb) == "Booked")
                {
                    panel21.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room1_lb, date5_lb) == "Unavailable")
                {
                    panel21.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel21.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel22.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room2_lb, date5_lb) == "Booked")
                {
                    panel22.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room2_lb, date5_lb) == "Unavailable")
                {
                    panel22.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel22.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel23.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room3_lb, date5_lb) == "Booked")
                {
                    panel23.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room3_lb, date5_lb) == "Unavailable")
                {
                    panel23.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel23.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel24.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room4_lb, date5_lb) == "Booked")
                {
                    panel24.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room4_lb, date5_lb) == "Unavailable")
                {
                    panel24.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel24.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            #endregion
            #region Saturday
            if (panel25.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room1_lb, date6_lb) == "Booked")
                {
                    panel25.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room1_lb, date6_lb) == "Unavailable")
                {
                    panel25.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel25.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel26.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room2_lb, date6_lb) == "Booked")
                {
                    panel26.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room2_lb, date6_lb) == "Unavailable")
                {
                    panel26.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel26.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel27.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room3_lb, date6_lb) == "Booked")
                {
                    panel27.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room3_lb, date6_lb) == "Unavailable")
                {
                    panel27.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel27.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel28.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room4_lb, date6_lb) == "Booked")
                {
                    panel28.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room4_lb, date6_lb) == "Unavailable")
                {
                    panel28.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel28.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            #endregion
            #region Sunday
            if (panel29.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room1_lb, date7_lb) == "Booked")
                {
                    panel29.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room1_lb, date7_lb) == "Unavailable")
                {
                    panel29.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel29.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel30.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room2_lb, date7_lb) == "Booked")
                {
                    panel30.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room2_lb, date7_lb) == "Unavailable")
                {
                    panel30.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel30.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel31.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room3_lb, date7_lb) == "Booked")
                {
                    panel31.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room3_lb, date7_lb) == "Unavailable")
                {
                    panel31.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel31.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel32.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room4_lb, date7_lb) == "Booked")
                {
                    panel32.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room4_lb, date7_lb) == "Unavailable")
                {
                    panel32.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel32.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            #endregion
            #endregion
        }

        //Style for form
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            RoomMain add = new RoomMain();
            add.Show();
        }
        public string ColorChange(Label room, Label date)
        {
            MY_DB mydb = new MY_DB();
            //take ID for room
            string roomID = room.Text;
            string newRoom = roomID.Substring(roomID.Length - 3, 3);

            //Take date
            CultureInfo culture = new CultureInfo("es-ES");
            string datetime = date.Text;
            DateTime newdate = DateTime.Parse(datetime, culture);
            string formatdate = newdate.ToString("yyyy-MM-dd");

            //Take status
            if(formatdate != DateTime.Today.ToString("yyyy-MM-dd"))
            {
                SqlCommand cmd = new SqlCommand("select RoomID, StartTime, EndTime, Date, State from Booking where RoomID = " + newRoom + " and Date = '" + formatdate + "' and State = 'Booked'");
                cmd.Connection = mydb.getConnection;
                mydb.openConnection();
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    return "Booked";
                }
                else
                {
                    mydb.closeConnection();
                    SqlCommand cmd1 = new SqlCommand("select RoomID, StartTime, EndTime, Date, State from Booking where RoomID = " + newRoom + " and Date = '" + formatdate + "' and State = 'Unavailable'");
                    cmd1.Connection = mydb.getConnection;
                    mydb.openConnection();
                    SqlDataReader data1 = cmd1.ExecuteReader();
                    if (data1.Read() == true)
                    {
                        return "Unavailable";
                    }
                    return "Available";
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select RoomID, StartTime, EndTime, Date, State from Booking where RoomID = " + newRoom + " and Date = '" + formatdate + "' and State = 'Booked' and StartTime <= '" + DateTime.Now.TimeOfDay + "' and EndTime > '" + DateTime.Now.TimeOfDay + "'");
                cmd.Connection = mydb.getConnection;
                mydb.openConnection();
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    return "Booked";
                }
                else
                {
                    mydb.closeConnection();
                    SqlCommand cmd1 = new SqlCommand("select RoomID, StartTime, EndTime, Date, State from Booking where RoomID = " + newRoom + " and Date = '" + formatdate + "' and State = 'Unavailable'");
                    cmd1.Connection = mydb.getConnection;
                    mydb.openConnection();
                    SqlDataReader data1 = cmd1.ExecuteReader();
                    if (data1.Read() == true)
                    {
                        return "Unavailable";
                    }
                    return "Available";
                }
            }
        }   

        //Check overdate panel

        public int OverDate(Label date)
        {
            CultureInfo culture = new CultureInfo("es-ES");
            string datetime = date.Text;
            DateTime newDate = DateTime.Parse(datetime, culture);

            string current = DateTime.Now.ToString("dd/MM/yyyy");
            DateTime newCurrent = DateTime.Parse(current, culture);

            int result = DateTime.Compare(newDate, newCurrent);

            if (result < 0) return -1;
            else if (result == 0) return 0;
            else return 1;
        }
        //load floor in database
        public void LoadFloor(string cmd)
        {
            MY_DB mydb = new MY_DB();
            SqlCommand command = new SqlCommand(cmd, mydb.getConnection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            floor_cb.DataSource = dt;
            floor_cb.ValueMember = "Floor";
        }

        //Load room by floor
        private void floor_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            room1_lb.Text = "A1-" + (floor_cb.SelectedIndex + 1).ToString() + "01";
            room2_lb.Text = "A1-" + (floor_cb.SelectedIndex + 1).ToString() + "02";
            room3_lb.Text = "A1-" + (floor_cb.SelectedIndex + 1).ToString() + "03";
            room4_lb.Text = "A1-" + (floor_cb.SelectedIndex + 1).ToString() + "04";
            #region load OverDate
            if (OverDate(date1_lb) < 0)
            {
                panel5.BackColor = Color.FromArgb(181, 34, 61);
                panel6.BackColor = Color.FromArgb(181, 34, 61);
                panel7.BackColor = Color.FromArgb(181, 34, 61);
                panel8.BackColor = Color.FromArgb(181, 34, 61);
            }
            if (OverDate(date2_lb) < 0)
            {
                panel9.BackColor = Color.FromArgb(181, 34, 61);
                panel10.BackColor = Color.FromArgb(181, 34, 61);
                panel11.BackColor = Color.FromArgb(181, 34, 61);
                panel12.BackColor = Color.FromArgb(181, 34, 61);
            }
            if (OverDate(date3_lb) < 0)
            {
                panel13.BackColor = Color.FromArgb(181, 34, 61);
                panel14.BackColor = Color.FromArgb(181, 34, 61);
                panel15.BackColor = Color.FromArgb(181, 34, 61);
                panel16.BackColor = Color.FromArgb(181, 34, 61);
            }
            if (OverDate(date4_lb) < 0)
            {
                panel17.BackColor = Color.FromArgb(181, 34, 61);
                panel18.BackColor = Color.FromArgb(181, 34, 61);
                panel19.BackColor = Color.FromArgb(181, 34, 61);
                panel20.BackColor = Color.FromArgb(181, 34, 61);
            }
            if (OverDate(date5_lb) < 0)
            {
                panel21.BackColor = Color.FromArgb(181, 34, 61);
                panel22.BackColor = Color.FromArgb(181, 34, 61);
                panel23.BackColor = Color.FromArgb(181, 34, 61);
                panel24.BackColor = Color.FromArgb(181, 34, 61);
            }
            if (OverDate(date6_lb) < 0)
            {
                panel25.BackColor = Color.FromArgb(181, 34, 61);
                panel26.BackColor = Color.FromArgb(181, 34, 61);
                panel27.BackColor = Color.FromArgb(181, 34, 61);
                panel28.BackColor = Color.FromArgb(181, 34, 61);
            }
            if (OverDate(date7_lb) < 0)
            {
                panel29.BackColor = Color.FromArgb(181, 34, 61);
                panel30.BackColor = Color.FromArgb(181, 34, 61);
                panel31.BackColor = Color.FromArgb(181, 34, 61);
                panel32.BackColor = Color.FromArgb(181, 34, 61);
            }
            #endregion
            #region Load Room information
            #region Monday
            if (panel5.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room1_lb, date1_lb) == "Booked")
                {
                    panel5.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room1_lb, date1_lb) == "Unavailable")
                {
                    panel5.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel5.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel6.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room2_lb, date1_lb) == "Booked")
                {
                    panel6.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room2_lb, date1_lb) == "Unavailable")
                {
                    panel6.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel6.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel7.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room3_lb, date1_lb) == "Booked")
                {
                    panel7.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room3_lb, date1_lb) == "Unavailable")
                {
                    panel7.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel7.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel8.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room4_lb, date1_lb) == "Booked")
                {
                    panel8.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room4_lb, date1_lb) == "Unavailable")
                {
                    panel8.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel8.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            #endregion
            #region Tuesday
            if (panel9.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room1_lb, date2_lb) == "Booked")
                {
                    panel9.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room1_lb, date2_lb) == "Unavailable")
                {
                    panel9.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel9.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel10.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room2_lb, date2_lb) == "Booked")
                {
                    panel10.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room2_lb, date2_lb) == "Unavailable")
                {
                    panel10.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel10.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel11.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room3_lb, date2_lb) == "Booked")
                {
                    panel11.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room3_lb, date2_lb) == "Unavailable")
                {
                    panel11.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel11.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel12.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room4_lb, date2_lb) == "Booked")
                {
                    panel12.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room4_lb, date2_lb) == "Unavailable")
                {
                    panel12.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel12.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            #endregion
            #region Wednesday
            if (panel13.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room1_lb, date3_lb) == "Booked")
                {
                    panel13.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room1_lb, date3_lb) == "Unavailable")
                {
                    panel13.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel13.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel14.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room2_lb, date3_lb) == "Booked")
                {
                    panel14.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room2_lb, date3_lb) == "Unavailable")
                {
                    panel14.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel14.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel15.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room3_lb, date3_lb) == "Booked")
                {
                    panel15.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room3_lb, date3_lb) == "Unavailable")
                {
                    panel15.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel15.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel16.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room4_lb, date3_lb) == "Booked")
                {
                    panel16.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room4_lb, date3_lb) == "Unavailable")
                {
                    panel16.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel16.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            #endregion
            #region Thursday
            if (panel17.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room1_lb, date4_lb) == "Booked")
                {
                    panel17.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room1_lb, date4_lb) == "Unavailable")
                {
                    panel17.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel17.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel18.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room2_lb, date4_lb) == "Booked")
                {
                    panel18.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room2_lb, date4_lb) == "Unavailable")
                {
                    panel18.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel18.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel19.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room3_lb, date4_lb) == "Booked")
                {
                    panel19.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room3_lb, date4_lb) == "Unavailable")
                {
                    panel19.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel19.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel20.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room4_lb, date4_lb) == "Booked")
                {
                    panel20.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room4_lb, date4_lb) == "Unavailable")
                {
                    panel20.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel20.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            #endregion
            #region Friday
            if (panel21.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room1_lb, date5_lb) == "Booked")
                {
                    panel21.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room1_lb, date5_lb) == "Unavailable")
                {
                    panel21.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel21.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel22.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room2_lb, date5_lb) == "Booked")
                {
                    panel22.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room2_lb, date5_lb) == "Unavailable")
                {
                    panel22.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel22.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel23.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room3_lb, date5_lb) == "Booked")
                {
                    panel23.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room3_lb, date5_lb) == "Unavailable")
                {
                    panel23.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel23.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel24.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room4_lb, date5_lb) == "Booked")
                {
                    panel24.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room4_lb, date5_lb) == "Unavailable")
                {
                    panel24.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel24.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            #endregion
            #region Saturday
            if (panel25.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room1_lb, date6_lb) == "Booked")
                {
                    panel25.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room1_lb, date6_lb) == "Unavailable")
                {
                    panel25.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel25.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel26.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room2_lb, date6_lb) == "Booked")
                {
                    panel26.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room2_lb, date6_lb) == "Unavailable")
                {
                    panel26.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel26.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel27.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room3_lb, date6_lb) == "Booked")
                {
                    panel27.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room3_lb, date6_lb) == "Unavailable")
                {
                    panel27.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel27.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel28.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room4_lb, date6_lb) == "Booked")
                {
                    panel28.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room4_lb, date6_lb) == "Unavailable")
                {
                    panel28.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel28.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            #endregion
            #region Sunday
            if (panel29.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room1_lb, date7_lb) == "Booked")
                {
                    panel29.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room1_lb, date7_lb) == "Unavailable")
                {
                    panel29.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel29.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel30.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room2_lb, date7_lb) == "Booked")
                {
                    panel30.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room2_lb, date7_lb) == "Unavailable")
                {
                    panel30.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel30.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel31.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room3_lb, date7_lb) == "Booked")
                {
                    panel31.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room3_lb, date7_lb) == "Unavailable")
                {
                    panel31.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel31.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            if (panel32.BackColor != Color.FromArgb(181, 34, 61))
            {
                if (ColorChange(room4_lb, date7_lb) == "Booked")
                {
                    panel32.BackColor = Color.FromArgb(255, 255, 0);
                }
                else if (ColorChange(room4_lb, date7_lb) == "Unavailable")
                {
                    panel32.BackColor = Color.FromArgb(166, 166, 166);
                }
                else
                {
                    panel32.BackColor = Color.FromArgb(53, 211, 53);
                }
            }
            #endregion
            #endregion
        }

        #region Add contextmenu
        public void AddConstripMenu(Panel a)
        {
            ContextMenuStrip Menu = new ContextMenuStrip();
            var item1 = new ToolStripButton() { Text = "Status", AutoSize = true };
            var item2 = new ToolStripButton() { Text = "Booking room", AutoSize = true };
            var item3 = new ToolStripButton() { Text = "Pay", AutoSize = true };
            Menu.Items.Add(item1);
            Menu.Items.Add(item2);
            Menu.Items.Add(item3);
            item1.Click += Item1_Click;
            if(a.BackColor != Color.FromArgb(166, 166, 166))
            {
                item2.Click += Item2_Click;
                item3.Click += Item3_Click;
            }
            
            Menu.Show(this, this.PointToClient(MousePosition));
        }

        private void Item3_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
        }

        private void Item2_Click(object sender, EventArgs e)
        {
            Booking book = new Booking();
            book.Show();
        }

        private void Item1_Click(object sender, EventArgs e)
        {
            Status state = new Status();
            state.Show();
        }

        #endregion

        #region Click for detail

        private void panel5_DoubleClick(object sender, EventArgs e)
        {
            if(panel5.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel5);
            }    
        }

        private void panel9_DoubleClick(object sender, EventArgs e)
        {
            if (panel9.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel9);
            }
        }

        private void panel13_DoubleClick(object sender, EventArgs e)
        {
            if (panel13.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel13);
            }
        }

        private void panel17_DoubleClick(object sender, EventArgs e)
        {
            if (panel17.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel17);
            }
        }

        private void panel21_DoubleClick(object sender, EventArgs e)
        {
            if (panel21.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel21);
            }
        }

        private void panel25_DoubleClick(object sender, EventArgs e)
        {
            if (panel25.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel25);
            }
        }

        private void panel29_DoubleClick(object sender, EventArgs e)
        {
            if (panel29.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel29);
            }
        }

        private void panel6_DoubleClick(object sender, EventArgs e)
        {
            if (panel6.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel6);
            }
        }

        private void panel10_DoubleClick(object sender, EventArgs e)
        {
            if (panel10.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel10);
            }
        }

        private void panel14_DoubleClick(object sender, EventArgs e)
        {
            if (panel14.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel14);
            }
        }

        private void panel18_DoubleClick(object sender, EventArgs e)
        {
            if (panel18.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel18);
            }
        }

        private void panel22_DoubleClick(object sender, EventArgs e)
        {
            if (panel22.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel22);
            }
        }

        private void panel26_DoubleClick(object sender, EventArgs e)
        {
            if (panel26.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel26);
            }
        }

        private void panel30_DoubleClick(object sender, EventArgs e)
        {
            if (panel30.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel30);
            }
        }

        private void panel7_DoubleClick(object sender, EventArgs e)
        {
            if (panel17.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel17);
            }
        }

        private void panel11_DoubleClick(object sender, EventArgs e)
        {
            if (panel11.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel11);
            }
        }

        private void panel15_DoubleClick(object sender, EventArgs e)
        {
            if (panel15.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel15);
            }
        }

        private void panel19_DoubleClick(object sender, EventArgs e)
        {
            if (panel19.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel19);
            }
        }

        private void panel23_DoubleClick(object sender, EventArgs e)
        {
            if (panel23.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel23);
            }
        }

        private void panel27_DoubleClick(object sender, EventArgs e)
        {
            if (panel27.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel27);
            }
        }

        private void panel31_DoubleClick(object sender, EventArgs e)
        {
            if (panel31.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel31);
            }
        }

        private void panel8_DoubleClick(object sender, EventArgs e)
        {
            if (panel18.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel18);
            }
        }

        private void panel12_DoubleClick(object sender, EventArgs e)
        {
            if (panel12.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel12);
            }
        }

        private void panel16_DoubleClick(object sender, EventArgs e)
        {
            if (panel16.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel16);
            }
        }

        private void panel20_DoubleClick(object sender, EventArgs e)
        {
            if (panel20.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel20);
            }
        }

        private void panel24_DoubleClick(object sender, EventArgs e)
        {
            if (panel24.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel24);
            }
        }

        private void panel28_DoubleClick(object sender, EventArgs e)
        {
            if (panel28.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel28);
            }
        }

        private void panel32_DoubleClick(object sender, EventArgs e)
        {
            if (panel32.BackColor != Color.FromArgb(181, 34, 61))
            {
                AddConstripMenu(panel32);
            }
        }
        #endregion

        private void booking_btn_Click(object sender, EventArgs e)
        {
            Booking book = new Booking();
            book.Show();
        }

        private void import_btn_Click(object sender, EventArgs e)
        {
            AddConstripMenuButton(import_btn);
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            Close();
            RoomMain rm = new RoomMain();
            rm.Show();
        }
        public void AddConstripMenuButton(Button a)
        {
            ContextMenuStrip Menu = new ContextMenuStrip();
            var choose1 = new ToolStripButton() { Text = "Import goods", AutoSize = true };
            var choose2 = new ToolStripButton() { Text = "Update goods", AutoSize = true };
            Menu.Items.Add(choose1);
            Menu.Items.Add(choose2);
            choose1.Click += Choose1_Click;
            choose2.Click += Choose2_Click;

            Menu.Show(1330, 392);
        }

        private void Choose2_Click(object sender, EventArgs e)
        {
            updateGoods update = new updateGoods();
            update.Show();
        }

        private void Choose1_Click(object sender, EventArgs e)
        {
            import import = new import();
            import.Show();
        }

        private void status_btn_Click(object sender, EventArgs e)
        {
            Status status = new Status();
            status.Show();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
