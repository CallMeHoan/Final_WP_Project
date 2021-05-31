using Final_WP_Project.Model;
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

namespace Final_WP_Project.View.Manager
{
    public partial class ClickSchdule_Schedule_ : Form
    {
        public ClickSchdule_Schedule_()
        {
            InitializeComponent();
            save_btn.BackColor = Color.FromArgb(48, 182, 251);
        }
        Human hu = new Human();
        string ca;
        string start = "";
        string attendance = "";
        public ClickSchdule_Schedule_(string ca)
        {
            this.ca = ca;
            InitializeComponent();
            save_btn.BackColor = Color.FromArgb(48, 182, 251);
        }
        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
        int h = Convert.ToInt32(Global.Hour);
        int m = Convert.ToInt32(Global.Minute);
        int d = Convert.ToInt32(Global.Day);
        string w = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            //m++;
            //if (d == 2)
            //{
            //    w = "Monday";
            //}
            //if (d == 3)
            //{
            //    w = "Tuesday";
            //}
            //if (d == 4)
            //{
            //    w = "Wednesday";
            //}
            //if (d == 5)
            //{
            //    w = "Thursday";
            //}
            
            //if (d == 6)
            //{
            //    w = "Friday";
            //}
            //if (d == 7)
            //{
            //    w = "Saturday";
            //}
            //if (d == 8)
            //{
            //    w = "Sunday";
            //}
            //if (m > 59)
            //{
            //    m = 0;
            //    h++;
            //    lb_hour.Text = h.ToString();
            //    lb_minute.Text = m.ToString();
            //    lb_dow.Text = w;
            //}

            //if (h > 23)
            //{
            //    h = 0;
            //    d++;
            //    lb_hour.Text = h.ToString();
            //    lb_minute.Text = m.ToString();
            //    lb_dow.Text = w;
            //}
            //if (d > 8)
            //{
            //    d = 2;
            //    lb_hour.Text = h.ToString();
            //    lb_minute.Text = m.ToString();
            //    lb_dow.Text = w;
            //}
            //else
            //{
            //    lb_hour.Text = h.ToString();
            //    lb_minute.Text = m.ToString();
            //    lb_dow.Text = w;
            //}
            //lb_hour.Text = h.ToString();
            //lb_minute.Text = m.ToString();
            //lb_dow.Text = w;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClickSchdule_Schedule__Load(object sender, EventArgs e)
        {
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
            timer1.Enabled = false;
            timer1.Start();
            lb_dow.Text = w;
            if(ca=="1a")
            {
                lb_hour.Text = "7h to 9h30 (late)";
                attendance = "Late";
                start = "7h";
                SqlCommand command = new SqlCommand("Select name, usertype from Employee e, WorkDay w where e.ID = w.EmployeeID and w.StartTime = @start and w.DayofWeek = @day;");
                command.Parameters.Add("@start", SqlDbType.NVarChar).Value = "7h";
                if (d != 8)
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                }
                else
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                }
                DataTable table = hu.gethummans(command);
            
                for(int i = 0; i < table.Rows.Count;i++)
                {
                    if(table.Rows[i][1].ToString().Trim()=="Manager")
                    {
               
                        txt_mana.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Reception")
                    {
                        txt_recep.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Labor")
                    {
                        txt_lab.Text = table.Rows[i][0].ToString();
                    }
                }
            }
            if (ca == "2a")
            {
                lb_hour.Text = "10h to 12h30 (late)";
                attendance = "Late";
                start = "10h";
                SqlCommand command = new SqlCommand("Select name, usertype from Employee e, WorkDay w where e.ID = w.EmployeeID and w.StartTime = @start and w.DayofWeek = @day;");
                command.Parameters.Add("@start", SqlDbType.NVarChar).Value = "10h";
                if (d != 8)
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                }
                else
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                }
                DataTable table = hu.gethummans(command);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][1].ToString().Trim() == "Manager")
                    {
                   
                        txt_mana.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Reception")
                    {
                        txt_recep.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Labor")
                    {
                        txt_lab.Text = table.Rows[i][0].ToString();
                    }
                }
            }
            if (ca == "3a")
            {
                lb_hour.Text = "13h to 15h30 (late)";
                attendance = "Late";
                start = "13h";
                SqlCommand command = new SqlCommand("Select name, usertype from Employee e, WorkDay w where e.ID = w.EmployeeID and w.StartTime = @start and w.DayofWeek = @day;");
                command.Parameters.Add("@start", SqlDbType.NVarChar).Value = "13h";
                if (d != 8)
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                }
                else
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                }
                DataTable table = hu.gethummans(command);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][1].ToString().Trim() == "Manager")
                    {
  
                        txt_mana.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Reception")
                    {
                        txt_recep.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Labor")
                    {
                        txt_lab.Text = table.Rows[i][0].ToString();
                    }
                }
            }
            if (ca == "4a")
            {
                lb_hour.Text = "16h to 18h30 (late)";
                attendance = "Late";
                start = "16h";
                SqlCommand command = new SqlCommand("Select name, usertype from Employee e, WorkDay w where e.ID = w.EmployeeID and w.StartTime = @start and w.DayofWeek = @day;");
                command.Parameters.Add("@start", SqlDbType.NVarChar).Value = "16h";
                if (d != 8)
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                }
                else
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                }
                DataTable table = hu.gethummans(command);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][1].ToString().Trim() == "Manager")
                    {
           
                        txt_mana.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Reception")
                    {
                        txt_recep.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Labor")
                    {
                        txt_lab.Text = table.Rows[i][0].ToString();
                    }
                }
            }
            if (ca == "5a")
            {
                lb_hour.Text = "19h to 21h30 (late)";
                attendance = "Late";
                start = "19h";
                SqlCommand command = new SqlCommand("Select name, usertype from Employee e, WorkDay w where e.ID = w.EmployeeID and w.StartTime = @start and w.DayofWeek = @day;");
                command.Parameters.Add("@start", SqlDbType.NVarChar).Value = "19h";
                if (d != 8)
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                }
                else
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                }
                DataTable table = hu.gethummans(command);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][1].ToString().Trim() == "Manager")
                    {
                  
                        txt_mana.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Reception")
                    {
                        txt_recep.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Labor")
                    {
                        txt_lab.Text = table.Rows[i][0].ToString();
                    }
                }
            }
            if (ca == "6a")
            {
                lb_hour.Text = "22h to 0h30 (late)";
                attendance = "Late";
                start = "22h";
                SqlCommand command = new SqlCommand("Select name, usertype from Employee e, WorkDay w where e.ID = w.EmployeeID and w.StartTime = @start and w.DayofWeek = @day;");
                command.Parameters.Add("@start", SqlDbType.NVarChar).Value = "22h";
                if (d != 8)
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                }
                else
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                }
                DataTable table = hu.gethummans(command);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][1].ToString().Trim() == "Manager")
                    {
          
                        txt_mana.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Reception")
                    {
                        txt_recep.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Labor")
                    {
                        txt_lab.Text = table.Rows[i][0].ToString();
                    }
                }
            }
            if (ca == "7a")
            {
                lb_hour.Text = "1h to 3h30 (late)";
                attendance = "Late";
                start = "1h";
                SqlCommand command = new SqlCommand("Select name, usertype from Employee e, WorkDay w where e.ID = w.EmployeeID and w.StartTime = @start and w.DayofWeek = @day;");
                command.Parameters.Add("@start", SqlDbType.NVarChar).Value = "1h";
                if (d != 8)
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                }
                else
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                }
                DataTable table = hu.gethummans(command);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][1].ToString().Trim() == "Manager")
                    {
                    
                        txt_mana.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Reception")
                    {
                        txt_recep.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Labor")
                    {
                        txt_lab.Text = table.Rows[i][0].ToString();
                    }
                }
            }
            if (ca == "8a")
            {
                lb_hour.Text = "4h to 6h30 (late)";
                attendance = "Late";
                start = "4h";
                SqlCommand command = new SqlCommand("Select name, usertype from Employee e, WorkDay w where e.ID = w.EmployeeID and w.StartTime = @start and w.DayofWeek = @day;");
                command.Parameters.Add("@start", SqlDbType.NVarChar).Value = "4h";
                if (d != 8)
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                }
                else
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                }
                DataTable table = hu.gethummans(command);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][1].ToString().Trim() == "Manager")
                    {
                  
                        txt_mana.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Reception")
                    {
                        txt_recep.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Labor")
                    {
                        txt_lab.Text = table.Rows[i][0].ToString();
                    }
                }
            }

            if (ca == "8b")
            {
                lb_hour.Text = "7h to 9h30";
                attendance = "Present";
                start = "7h";
                SqlCommand command = new SqlCommand("Select name, usertype from Employee e, WorkDay w where e.ID = w.EmployeeID and w.StartTime = @start and w.DayofWeek = @day;");
                command.Parameters.Add("@start", SqlDbType.NVarChar).Value = "7h";
                if (d != 8)
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                }
                else
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                }
                DataTable table = hu.gethummans(command);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][1].ToString().Trim() == "Manager")
                    {
                 
                        txt_mana.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Reception")
                    {
                        txt_recep.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Labor")
                    {
                        txt_lab.Text = table.Rows[i][0].ToString();
                    }
                }

            }
            if (ca == "1b")
            {
                lb_hour.Text = "10h to 12h30";
                attendance = "Present";
                start = "10h";
                SqlCommand command = new SqlCommand("Select name, usertype from Employee e, WorkDay w where e.ID = w.EmployeeID and w.StartTime = @start and w.DayofWeek = @day;");
                command.Parameters.Add("@start", SqlDbType.NVarChar).Value = "19h";
                if (d != 8)
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                }
                else
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                }
                DataTable table = hu.gethummans(command);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][1].ToString().Trim() == "Manager")
                    {
                       
                        txt_mana.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Reception")
                    {
                        txt_recep.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Labor")
                    {
                        txt_lab.Text = table.Rows[i][0].ToString();
                    }
                }
            }
            if (ca == "2b")
            {
                lb_hour.Text = "13h to 15h30";
                attendance = "Present";
                start = "13h";
                SqlCommand command = new SqlCommand("Select name, usertype from Employee e, WorkDay w where e.ID = w.EmployeeID and w.StartTime = @start and w.DayofWeek = @day;");
                command.Parameters.Add("@start", SqlDbType.NVarChar).Value = "13h";
                if (d != 8)
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                }
                else
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                }
                DataTable table = hu.gethummans(command);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][1].ToString().Trim() == "Manager")
                    {
                    
                        txt_mana.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Reception")
                    {
                        txt_recep.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Labor")
                    {
                        txt_lab.Text = table.Rows[i][0].ToString();
                    }
                }
            }
            if (ca == "3b")
            {
                lb_hour.Text = "16h to 18h30";
                attendance = "Present";
                start = "16h";
                SqlCommand command = new SqlCommand("Select name, usertype from Employee e, WorkDay w where e.ID = w.EmployeeID and w.StartTime = @start and w.DayofWeek = @day;");
                command.Parameters.Add("@start", SqlDbType.NVarChar).Value = "16h";
                if (d != 8)
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                }
                else
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                }
                DataTable table = hu.gethummans(command);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][1].ToString().Trim() == "Manager")
                    {
                       
                        txt_mana.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Reception")
                    {
                        txt_recep.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Labor")
                    {
                        txt_lab.Text = table.Rows[i][0].ToString();
                    }
                }
            }
            if (ca == "4b")
            {
                lb_hour.Text = "19h to 21h30";
                attendance = "Present";
                start = "19h";
                SqlCommand command = new SqlCommand("Select name, usertype from Employee e, WorkDay w where e.ID = w.EmployeeID and w.StartTime = @start and w.DayofWeek = @day;");
                command.Parameters.Add("@start", SqlDbType.NVarChar).Value = "19h";
                if (d != 8)
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                }
                else
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                }
                DataTable table = hu.gethummans(command);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][1].ToString().Trim() == "Manager")
                    {
                        
                        txt_mana.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Reception")
                    {
                        txt_recep.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Labor")
                    {
                        txt_lab.Text = table.Rows[i][0].ToString();
                    }
                }
            }
            if (ca == "5b")
            {
                lb_hour.Text = "22h to 0h30";
                attendance = "Present";
                start = "22h";
                SqlCommand command = new SqlCommand("Select name, usertype from Employee e, WorkDay w where e.ID = w.EmployeeID and w.StartTime = @start and w.DayofWeek = @day;");
                command.Parameters.Add("@start", SqlDbType.NVarChar).Value = "22h";
                if (d != 8)
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                }
                else
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                }
                DataTable table = hu.gethummans(command);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][1].ToString().Trim() == "Manager")
                    {
                       
                        txt_mana.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Reception")
                    {
                        txt_recep.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Labor")
                    {
                        txt_lab.Text = table.Rows[i][0].ToString();
                    }
                }
            }
            if (ca == "6b")
            {
                lb_hour.Text = "1h to 3h30";
                attendance = "Present";
                start = "1h";
                SqlCommand command = new SqlCommand("Select name, usertype from Employee e, WorkDay w where e.ID = w.EmployeeID and w.StartTime = @start and w.DayofWeek = @day;");
                command.Parameters.Add("@start", SqlDbType.NVarChar).Value = "1h";
                if (d != 8)
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                }
                else
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                }
                DataTable table = hu.gethummans(command);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][1].ToString().Trim() == "Manager")
                    {
                      
                        txt_mana.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Reception")
                    {
                        txt_recep.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Labor")
                    {
                        txt_lab.Text = table.Rows[i][0].ToString();
                    }
                }
            }
            if (ca == "7b")
            {
                lb_hour.Text = "4h to 6h30";
                attendance = "Present";
                start = "4h";
                SqlCommand command = new SqlCommand("Select name, usertype from Employee e, WorkDay w where e.ID = w.EmployeeID and w.StartTime = @start and w.DayofWeek = @day;");
                command.Parameters.Add("@start", SqlDbType.NVarChar).Value = "4h";
                if (d != 8)
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                }
                else
                {
                    command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                }
                DataTable table = hu.gethummans(command);

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][1].ToString().Trim() == "Manager")
                    {
                       
                        txt_mana.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Reception")
                    {
                        txt_recep.Text = table.Rows[i][0].ToString();
                    }
                    if (table.Rows[i][1].ToString().Trim() == "Labor")
                    {
                        txt_lab.Text = table.Rows[i][0].ToString();
                    }
                }
            }

            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_hour_Click(object sender, EventArgs e)
        {
            h++;

        }

        private void lb_minute_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled==true)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
        }
        MY_DB db = new MY_DB();
        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (manager_checkbox.Checked)
                {
                    SqlCommand command1 = new SqlCommand("Select id from Employee where name =@id");
                    command1.Parameters.Add("@id", SqlDbType.NVarChar).Value = txt_mana.Text.Trim();
                    DataTable table1 = hu.gethummans(command1);

                    SqlCommand command = new SqlCommand("UPDATE Workday SET Attendance = '" + attendance + "' WHERE EmployeeID = @id1 and Dayofweek = @day and StartTime = @start;", db.getConnection);
                    command.Parameters.Add("@id1", SqlDbType.NVarChar).Value = table1.Rows[0][0].ToString();
                    if (d != 8)
                    {
                        command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                    }
                    else
                    {
                        command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                    }
                    command.Parameters.Add("@start", SqlDbType.NVarChar).Value = start;
                    hu.gethummans(command);
                }
                if (reception_checkbox.Checked)
                {
                    SqlCommand command1 = new SqlCommand("Select id from Employee where name =@id");
                    command1.Parameters.Add("@id", SqlDbType.NVarChar).Value = txt_recep.Text.Trim();
                    DataTable table1 = hu.gethummans(command1);

                    SqlCommand command = new SqlCommand("UPDATE Workday SET Attendance = '" + attendance + "' WHERE EmployeeID = @id1 and Dayofweek = @day and StartTime = @start;", db.getConnection);
                    command.Parameters.Add("@id1", SqlDbType.NVarChar).Value = table1.Rows[0][0].ToString();
                    if (d != 8)
                    {
                        command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                    }
                    else
                    {
                        command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                    }
                    command.Parameters.Add("@start", SqlDbType.NVarChar).Value = start;
                    hu.gethummans(command);
                }
                if (emp1_checkbox.Checked)
                {
                    SqlCommand command1 = new SqlCommand("Select id from Employee where name =@id");
                    command1.Parameters.Add("@id", SqlDbType.NVarChar).Value = txt_lab.Text.Trim();
                    DataTable table1 = hu.gethummans(command1);

                    SqlCommand command = new SqlCommand("UPDATE Workday SET Attendance = '" + attendance + "' WHERE EmployeeID = @id1 and Dayofweek = @day and StartTime = @start;", db.getConnection);
                    command.Parameters.Add("@id1", SqlDbType.NVarChar).Value = table1.Rows[0][0].ToString();
                    if (d != 8)
                    {
                        command.Parameters.Add("@day", SqlDbType.NVarChar).Value = d.ToString();
                    }
                    else
                    {
                        command.Parameters.Add("@day", SqlDbType.NVarChar).Value = "cn";
                    }
                    command.Parameters.Add("@start", SqlDbType.NVarChar).Value = start;
                    hu.gethummans(command);
                }
                MessageBox.Show("Attendance checked", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("System eror :(", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void manager_checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void emp1_checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void emp3_checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void reception_checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ClickSchdule_Schedule__Load(sender, e);
        }
    }
}
