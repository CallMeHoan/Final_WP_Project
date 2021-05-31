using Final_WP_Project.View.Manager.Employee_click;
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
    public partial class ReceptionLineClickForm_Manager_ : Form
    {
        public ReceptionLineClickForm_Manager_()
        {
            InitializeComponent();
            Style();
            
        }
        int id; string name; int phone; string position; string gender; string age;
        public ReceptionLineClickForm_Manager_(int id, string name, int phone, string position, string gender, string age)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.position = position;
            this.gender = gender;
            this.age = age;
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
            this.save_btn.BackColor = Color.FromArgb(48, 182, 251);
            this.save_btn.ForeColor = Color.FromArgb(255, 255, 255);
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
        private void receptionID_txt_Enter(object sender, EventArgs e)
        {
            if (receptionID_txt.Text == "Reception ID")
            {
                receptionID_txt.Text = "";
            }
        }

        private void receptionID_txt_Leave(object sender, EventArgs e)
        {
            if (receptionID_txt.Text == "")
            {
                receptionID_txt.Text = "Reception ID";
                receptionID_txt.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }

        //First name
        private void firstName_txt_Enter(object sender, EventArgs e)
        {
            if (firstName_txt.Text == "First name")
            {
                firstName_txt.Text = "";
            }
        }

        private void firstName_txt_Leave(object sender, EventArgs e)
        {
            if(firstName_txt.Text == "")
            {
                firstName_txt.Text = "First name";
                firstName_txt.ForeColor = Color.FromArgb(130, 130, 130);
            }    
        }

        //Last name
        private void lastName_txt_Enter(object sender, EventArgs e)
        {
            if (lastName_txt.Text == "Last name")
            {
                lastName_txt.Text = "";
            }
        }

        private void lastName_txt_Leave(object sender, EventArgs e)
        {
            if(lastName_txt.Text == "")
            {
                lastName_txt.Text = "First name";
                lastName_txt.ForeColor = Color.FromArgb(130, 130, 130);
            }
        }

        //Phone number

        private void phone_txt_Enter(object sender, EventArgs e)
        {
            if (phone_txt.Text == "Phone number")
            {
                phone_txt.Text = "";
            }
        }
        private void phone_txt_Leave(object sender, EventArgs e)
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

        private void ReceptionLineClickForm_Manager__Load(object sender, EventArgs e)
        {
            int index = name.IndexOf(" ");
           string a = name.Substring(0, index);
            string b = name.Substring(index);      
            firstName_txt.Text = a.Trim();
             lastName_txt.Text = b.Trim();
            receptionID_txt.Text = id.ToString();
            phone_txt.Text = phone.ToString();
            position_cb.Text = position;
            date_cb.Text = "1";
            month_cb.Text = "2";
            if(gender.Contains("F"))
            {
                female_rbtn.Checked = true;
            }
            else if(gender.Trim()=="Male")
            {
                male_rbtn.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            int i = 2021;
            for (; i > 1900; i--)
            {
                year_cb.Items.Add(i.ToString());
            }
            int j = 1;
            for (; j <= 12; j++)
            {
                month_cb.Items.Add(j.ToString());
            }
            year_cb.Text = (DateTime.Now.Year - Convert.ToInt32(age)).ToString();
        }

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
                        for (int t = 1; t <= 29; t++)
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

        private void save_btn_Click(object sender, EventArgs e)
        {
            Human human = new Human();
            string a = firstName_txt.Text + " " + lastName_txt.Text;
            string b;
            if(male_rbtn.Checked)
            {
                b = "Male";

            }
            else if(female_rbtn.Checked)
            {
                b = "Female";
            }
            else
            {
                b = "Other";
            }
            if (human.UpdateHumans(id.ToString(),a , Convert.ToInt32(phone_txt.Text), DateTime.Now.Year - Convert.ToInt32(year_cb.Text), position_cb.Text, b))
            {
                MessageBox.Show("Employee Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_pn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            Human h = new Human();
            DialogResult a = MessageBox.Show("Are you sure to delete this employee?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (a == DialogResult.Yes)
            {
                    if (h.deleteEmployee(receptionID_txt.Text))
                    {
                        MessageBox.Show("Employee deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Try again!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Salary_btn_Click(object sender, EventArgs e)
        {
            SalaryCompute f = new SalaryCompute(id.ToString().Trim());
            f.Show();
        }
    }
}
