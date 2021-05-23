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
    public partial class Schedule : Form
    {
        public Schedule()
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
        #endregion

        private void Schedule_Load(object sender, EventArgs e)
        {
           
            Notification_Schedule_ f = new Notification_Schedule_();
            f.ShowDialog();
            Label[,] A = new Label[10, 10];
            int x0 = 323;
            int y0 = 219;
            int dx = 0;
            int dy = 0;
            for(int i = 0; i < 8;i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Text = "Dat(5)\n" + "Hoan(6)\n" + "Vu(1), Duc(2), An(3)";
                    label.Location = new Point(x0 + dx, y0 +dy);
                    label.Font = new Font("Poppins", 8);
                    if (i <= 3 && j<=5)
                    {
                        label.BackColor = Color.DeepSkyBlue;
                        label.BringToFront();
                        dx += 148;
                        A[i, j] = label;
                    }
                    else if(i>3 && j<=5)
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
                dy+=72;
            }// Khởi tạo mảng label

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 8; j++)
                {

                }
            }


            string[,] matrix = new string[8, 7] {
                { "3", "3", "3", "3", "3", "3", "3" },
                { "2", "2", "2", "2", "2", "2", "2" },
                { "2", "2", "2", "2", "2", "2", "2" },
                { "2", "2", "2", "2", "2", "2", "2" },
                { "3", "3", "3", "3", "3", "3", "3" },
                { "2", "2", "2", "2", "2", "2", "2" },
                { "2", "2", "2", "2", "2", "2", "2" },
                { "2", "2", "2", "2", "2", "2", "2" } };

            Human h = new Human();

            SqlCommand command = new SqlCommand("Select name from Employee where usertype = 'reception'");
            DataTable table = h.gethummans(command); // table chứa Lễ tân

            SqlCommand command1 = new SqlCommand("Select name from Employee where usertype = 'Manager'");
            DataTable table1 = h.gethummans(command1); // table chứa Quản lí

            SqlCommand command2 = new SqlCommand("Select name from Employee where usertype = 'Labor'");
            DataTable table2 = h.gethummans(command2); // table chứa Lao công
            int k = 1;
            int k1 = 0;
            string te = "";
            int labor_pos=0;
            string magic = (Convert.ToInt32("142857") * new Random(DateTime.Now.Millisecond).Next(1, 7)).ToString();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrix[j, i] == "3") // Quản lí + Lễ Tân + Lao Công
                    {

                        int random = new Random(DateTime.Now.Millisecond).Next(0, 2);
                        int random1 = new Random(DateTime.Now.Millisecond).Next(0, 4);
                        if (k == 1)
                        {
                            A[j, i].Text = table1.Rows[random][0].ToString() + "(Manag)";
                            k = 0;
                            
                            if (k1 < 2)
                            {
                                A[j, i].Text += "\n" + table.Rows[random1][0].ToString() + "(Recep)";
                                k1++;
                            }
                           else if (k1 > 1 && k1 < 4)
                            {
                                A[j, i].Text += "\n" + table.Rows[3 - random1][0].ToString() + "(Recep)";
                                k1++;
                            }
                            else if (k1 > 3)
                            {
                                for (int z = 0; z < table.Rows.Count; z++)
                                {
                                    if (table.Rows[z][0] != table.Rows[3 - random1][0] && table.Rows[z][0] != table.Rows[random1][0]&& table.Rows[z][0].ToString()!=te)
                                    {
                                        A[j, i].Text += "\n" + table.Rows[z][0] + "(Recep)";
                                        te = table.Rows[z][0].ToString();
                                        break;
                                    }
                                }

                            }
                        }
                        else
                        {
                            A[j, i].Text = table1.Rows[Math.Abs((1) - random)][0].ToString() + "(Manag)";
                            k = 1;
                            if (k1 < 2)
                            {
                                A[j, i].Text += "\n" + table.Rows[random1][0].ToString() + "(Recep)";
                                k1++;
                            }
                            else if (k1 > 1 && k1 < 4)
                            {
                                A[j, i].Text += "\n" + table.Rows[3 - random1][0].ToString() + "(Recep)";
                                k1++;
                            }
                            else if (k1 > 3)
                            {
                                for (int z = 0; z < table.Rows.Count; z++)
                                {
                                    if (table.Rows[z][0] != table.Rows[3 - random1][0] && table.Rows[z][0] != table.Rows[random1][0] && table.Rows[z][0].ToString() != te)
                                    {
                                        A[j, i].Text += "\n" + table.Rows[z][0] +"(Recep)";
                                        te = table.Rows[z][0].ToString();
                                        break;
                                    }
                                }

                            }
                        }
                        if(magic[i].ToString()=="1")
                        {
                            labor_pos = 0;
                        }
                        if (magic[i].ToString() == "4")
                        {
                            labor_pos = 1;
                        }
                        if (magic[i].ToString() == "2")
                        {
                            labor_pos = 2;
                        }
                        if (magic[i].ToString() == "8")
                        {
                            labor_pos = 3;
                        }
                        if (magic[i].ToString() == "5")
                        {
                            labor_pos = 4;
                        }
                        if (magic[i].ToString() == "7")
                        {
                            labor_pos = 5;
                        }
                        A[j, i].Text += "\n" + table2.Rows[labor_pos][0]+"(Lab)";
                    }
                  
                }
            }
             k = 1;
             k1 = 0;
             te = "";
             labor_pos = 0;
             magic = (Convert.ToInt32("142857") * new Random(DateTime.Now.Millisecond+3012).Next(1, 7)).ToString();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 4; j < 7; j++)
                {
                    if (matrix[j, i] == "3") // Quản lí + Lễ Tân + Lao Công
                    {

                        int random = new Random(DateTime.Now.Millisecond + 3012).Next(0, 2);
                        int random1 = new Random(DateTime.Now.Millisecond + 3012).Next(0, 4);
                        if (k == 1)
                        {
                            A[j, i].Text = table1.Rows[random][0].ToString() + "(Manag)";
                            k = 0;

                            if (k1 < 2)
                            {
                                A[j, i].Text += "\n" + table.Rows[random1][0].ToString() + "(Recep)";
                                k1++;
                            }
                            else if (k1 > 1 && k1 < 4)
                            {
                                A[j, i].Text += "\n" + table.Rows[3 - random1][0].ToString() + "(Recep)";
                                k1++;
                            }
                            else if (k1 > 3)
                            {
                                for (int z = 0; z < table.Rows.Count; z++)
                                {
                                    if (table.Rows[z][0] != table.Rows[3 - random1][0] && table.Rows[z][0] != table.Rows[random1][0] && table.Rows[z][0].ToString() != te)
                                    {
                                        A[j, i].Text += "\n" + table.Rows[z][0] + "(Recep)";
                                        te = table.Rows[z][0].ToString();
                                        break;
                                    }
                                }

                            }
                        }
                        else
                        {
                            A[j, i].Text = table1.Rows[Math.Abs((1) - random)][0].ToString() + "(Manag)";
                            k = 1;
                            if (k1 < 2)
                            {
                                A[j, i].Text += "\n" + table.Rows[random1][0].ToString() + "(Recep)";
                                k1++;
                            }
                            else if (k1 > 1 && k1 < 4)
                            {
                                A[j, i].Text += "\n" + table.Rows[3 - random1][0].ToString() + "(Recep)";
                                k1++;
                            }
                            else if (k1 > 3)
                            {
                                for (int z = 0; z < table.Rows.Count; z++)
                                {
                                    if (table.Rows[z][0] != table.Rows[3 - random1][0] && table.Rows[z][0] != table.Rows[random1][0] && table.Rows[z][0].ToString() != te)
                                    {
                                        A[j, i].Text += "\n" + table.Rows[z][0] + "(Recep)";
                                        te = table.Rows[z][0].ToString();
                                        break;
                                    }
                                }

                            }
                        }
                        if (magic[i].ToString() == "1")
                        {
                            labor_pos = 0;
                        }
                        if (magic[i].ToString() == "4")
                        {
                            labor_pos = 1;
                        }
                        if (magic[i].ToString() == "2")
                        {
                            labor_pos = 2;
                        }
                        if (magic[i].ToString() == "8")
                        {
                            labor_pos = 3;
                        }
                        if (magic[i].ToString() == "5")
                        {
                            labor_pos = 4;
                        }
                        if (magic[i].ToString() == "7")
                        {
                            labor_pos = 5;
                        }
                        A[j, i].Text += "\n" + table2.Rows[labor_pos][0] + "(Lab)";
                    }

                }
            }
            k = 1;
             k1 = 0;
             te = "";
            int l = 0;
            int index = 0;
            string[] temp = new string[30];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 4; j < 7; j++)
                {
                    if (matrix[j, i] == "3") // Quản lí + Lễ Tân
                    {
                        index = A[j, i].Text.LastIndexOf("\n");
                        temp[l] = A[j, i].Text.Substring(0,index);
                        l++;
                    }
                }
            }
            l = 0;
      
            for (int i = 5; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (matrix[i, j] =="2") // Quản lí + Lễ Tân
                    {
                        A[i, j].Text = temp[l];
                        l++;
                    }
                }
                l = 0;
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrix[j, i] == "3") // Quản lí + Lễ Tân
                    {
                        index = A[j, i].Text.LastIndexOf("\n");
                        temp[l] = A[j, i].Text.Substring(0, index);
                        l++;
                    }
                }
            }
            l = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (matrix[i, j] == "2") // Quản lí + Lễ Tân
                    {
                        A[i, j].Text = temp[l];
                        l++;
                    }
                }
                l = 0;
            }

            SqlCommand command3 = new SqlCommand("Select name,usertype from Employee where usertype = 'reception' or usertype = 'Manager'");
            DataTable table3 = h.gethummans(command3);
            SqlCommand command4 = new SqlCommand("Select name,usertype from Employee where usertype = 'Labor'");
            DataTable table4 = h.gethummans(command4);
            int randomc = new Random(DateTime.Now.Millisecond + 2021).Next(0, 6);
            for (int i = 0; i <4;i++)
            {
                A[i, 6].Text = table3.Rows[randomc][0].ToString() + "("+table3.Rows[randomc][1].ToString().Substring(0,5) +")";
                A[i, 6].Text += "\n"+ table4.Rows[randomc][0].ToString() + "(" + table4.Rows[randomc][1].ToString().Substring(0, 5) + ")";
            }
            int randomd = new Random(DateTime.Now.Millisecond + 3021).Next(0, 6);
            for (int i = 4; i < 8; i++)
            {
                A[i, 6].Text = table3.Rows[randomd][0].ToString() + "(" + table3.Rows[randomd][1].ToString().Substring(0, 5) + ")";
                A[i, 6].Text += "\n" + table4.Rows[randomd][0].ToString() + "(" + table4.Rows[randomd][1].ToString().Substring(0, 5) + ")";
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    this.Controls.Add(A[i, j]);
                    A[i,j].BringToFront();
                }
               
            } // Xuất mảng label

        }

        private void printPaycheck_btn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel65_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
