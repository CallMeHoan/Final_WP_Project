using Final_WP_Project.View.Manager.Employee_click;
using Final_WP_Project.View.Reception;
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
    public partial class ClickAddButtonForm_Manager_ : Form
    {
        int id1; string name1; int phone1; string position1; string gender1; int age1;
        public ClickAddButtonForm_Manager_(int id1, string name1, int phone1, string position1, string gender1, int age1)
        {
            this.id1 = id1;
            this.name1 = name1;
            this.phone1 = phone1;
            this.position1 = position1;
            this.gender1 = gender1;
            this.age1 = age1;
            InitializeComponent();
            Style();
        }
        public ClickAddButtonForm_Manager_()
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
            this.label3.ForeColor = Color.FromArgb(48, 182, 251);
            this.label4.ForeColor = Color.FromArgb(130, 130, 130);
            this.label5.ForeColor = Color.FromArgb(130, 130, 130);
            this.label6.ForeColor = Color.FromArgb(130, 130, 130);


            //color for textbox
            this.receptionID_txt.ForeColor = Color.FromArgb(130, 130, 130);
            this.firstName_txt.ForeColor = Color.FromArgb(130, 130, 130);
            this.lastName_txt.ForeColor = Color.FromArgb(130, 130, 130);
            this.phone_txt.ForeColor = Color.FromArgb(130, 130, 130);

            //Color for button

            //save button
            this.next_btn.BackColor = Color.FromArgb(48, 182, 251);
            this.next_btn.ForeColor = Color.FromArgb(255, 255, 255);
            //Cancel button
            this.cancel_btn.BackColor = Color.FromArgb(48, 182, 251);
            this.cancel_btn.ForeColor = Color.FromArgb(255, 255, 255);

            //Color for text box
            this.receptionID_txt.BackColor = Color.FromArgb(228, 221, 221);
            this.firstName_txt.BackColor = Color.FromArgb(228, 221, 221);
            this.lastName_txt.BackColor = Color.FromArgb(228, 221, 221);
            this.phone_txt.BackColor = Color.FromArgb(228, 221, 221);

            //no border button
            NoBorderButton(reception_btn);
            NoBorderButton(employee_btn);
            NoBorderButton(room_btn);
            NoBorderButton(schedule_btn);
            NoBorderButton(report_btn);
            NoBorderButton(static_btn);
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

        /*Create Placeholder for each textbox*/

        //Reception ID

        private void receptionID_txt_Enter_1(object sender, EventArgs e)
        {
            if (receptionID_txt.Text == "Reception ID")
            {
                receptionID_txt.Text = "";
            }
        }

        private void receptionID_txt_Leave_1(object sender, EventArgs e)
        {
            if (receptionID_txt.Text == "")
            {
                receptionID_txt.Text = "Reception ID";
                receptionID_txt.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }


        //First name


        private void firstName_txt_Enter_1(object sender, EventArgs e)
        {
            if (firstName_txt.Text == "First name")
            {
                firstName_txt.Text = "";
            }
        }

        private void firstName_txt_Leave_1(object sender, EventArgs e)
        {
            if (firstName_txt.Text == "")
            {
                firstName_txt.Text = "First name";
                firstName_txt.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }


        //Last name

        private void lastName_txt_Enter_1(object sender, EventArgs e)
        {
            if (lastName_txt.Text == "Last name")
            {
                lastName_txt.Text = "";
            }
        }

        private void lastName_txt_Leave_1(object sender, EventArgs e)
        {
            if (lastName_txt.Text == "")
            {
                lastName_txt.Text = "First name";
                lastName_txt.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }

        //Phone number

        private void phone_txt_Enter_1(object sender, EventArgs e)
        {
            if (phone_txt.Text == "Phone number")
            {
                phone_txt.Text = "";
            }
        }

        private void phone_txt_Leave_1(object sender, EventArgs e)
        {
            if (phone_txt.Text == "")
            {
                phone_txt.Text = "Phone number";
                phone_txt.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }
        //Date combo Box

        private void date_cb_Enter(object sender, EventArgs e)
        {
            if (date_cb.Text == "Date")
            {
                phone_txt.Text = "";
            }
        }

        private void date_cb_Leave(object sender, EventArgs e)
        {
            if (date_cb.Text == "")
            {
                date_cb.Text = "Date";
                date_cb.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }

        //Month combo Box

        private void month_cb_Enter(object sender, EventArgs e)
        {
            if (month_cb.Text == "Date")
            {
                month_cb.Text = "";
            }
        }

        private void month_cb_Leave(object sender, EventArgs e)
        {
            if (month_cb.Text == "")
            {
                month_cb.Text = "Date";
                month_cb.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }

        //year combo box
        private void year_cb_Enter(object sender, EventArgs e)
        {
            if (year_cb.Text == "Date")
            {
                year_cb.Text = "";
            }
        }

        private void year_cb_Leave(object sender, EventArgs e)
        {
            if (year_cb.Text == "")
            {
                year_cb.Text = "Date";
                year_cb.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }
        #endregion

        private void main_pn_Paint(object sender, PaintEventArgs e)
        {
              
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int id = Convert.ToInt32(receptionID_txt.Text);
                string name = firstName_txt.Text + " " + lastName_txt.Text;
                int phone = Convert.ToInt32(phone_txt.Text);
                string position = position_cb.Text;
                int age = Convert.ToInt32(DateTime.Now.Year) - Convert.ToInt32(year_cb.Text);
                string gender;
                if (male_rbtn.Checked)
                {
                    gender = "Male";
                }
                else if (female_rbtn.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Other";
                }

                ClickNext_Manage_ f = new ClickNext_Manage_(id, name, phone, position, gender, age);
                f.Show();
            }
            else
            {
                MessageBox.Show("Empty Fields", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        bool verif()
        {
            if ((receptionID_txt.Text.Trim() == "Reception ID")
                || (firstName_txt.Text.Trim() == "First name")
                || (lastName_txt.Text.Trim() == "Last name")
                || (phone_txt.Text.Trim() == "Phone number")
                || (year_cb.Text.Trim()== "Year")
                ||(date_cb.Text.Trim()== "Date")
                ||(month_cb.Text.Trim()=="Month"))
            {
                return false;
            }
             return true;
        }
        public void ClickAddButtonForm_Manager__Load(object sender, EventArgs e)
        {
            if (Global.isManager == false)
            {
                reception_btn.Visible = false;
                static_btn.Visible = false;
            }
            int i = 2021;
    
            for (; i > 1900; i--)
            {
                year_cb.Items.Add(i.ToString());
            }
            int j = 1;
            for (; j <=12; j++)
            {
                month_cb.Items.Add(j.ToString());
            }
          
        }

        private void date_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

               //Đưa ngày vào combobox
        private void month_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            date_cb.Items.Clear();
            switch (Convert.ToInt32(month_cb.Text))
            {
                case 1:
                    for (int t = 1; t <= 31; t++)
                    {
                        date_cb.Items.Add(t.ToString());
                    }
                    break;
                case 2:
                    if (DateTime.IsLeapYear(Convert.ToInt32(year_cb.Text)))
                    {
                        for (int t = 1; t <=29;t++ )
                        {
                            date_cb.Items.Add(t.ToString());
                        }
                    }
                    else
                    {
                        for (int t = 1; t <= 28; t++)
                        {
                            date_cb.Items.Add(t.ToString());
                        }
                    }
                    break;
                case 3:
                    for (int t = 1; t <= 31; t++)
                    {
                        date_cb.Items.Add(t.ToString());
                    }
                    break;
                case 4:
                    for (int t = 1; t <= 30; t++)
                    {
                        date_cb.Items.Add(t.ToString());
                    }
                    break;
                case 5:
                    for (int t = 1; t <= 31; t++)
                    {
                        date_cb.Items.Add(t.ToString());
                    }
                    break;
                case 6:
                    for (int t = 1; t <= 30; t++)
                    {
                        date_cb.Items.Add(t.ToString());
                    }
                    break;
                case 7:
                    for (int t = 1; t <= 31; t++)
                    {
                        date_cb.Items.Add(t.ToString());
                    }
                    break;
                case 8:
                    for (int t = 1; t <= 31; t++)
                    {
                        date_cb.Items.Add(t.ToString());
                    }
                    break;
                case 9:
                    for (int t = 1; t <= 30; t++)
                    {
                        date_cb.Items.Add(t.ToString());
                    }
                    break;
                case 10:
                    for (int t = 1; t <= 31; t++)
                    {
                        date_cb.Items.Add(t.ToString());
                    }
                    break;
                case 11:
                    for (int t = 1; t <= 30; t++)
                    {
                        date_cb.Items.Add(t.ToString());
                    }
                    break;
                case 12:
                    for (int t = 1; t <= 31; t++)
                    {
                        date_cb.Items.Add(t.ToString());
                    }
                    break;
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
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

        private void report_btn_Click(object sender, EventArgs e)
        {
            Close();
            ReportClick f = new ReportClick();
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
