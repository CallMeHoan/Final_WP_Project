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
    public partial class DayOff : Form
    {
        public DayOff()
        {
            InitializeComponent();

        }

        private void DayOff_Load(object sender, EventArgs e)
        {
            Human h = new Human();
            SqlCommand command = new SqlCommand("Select id, name from Employee");
            DataTable table = h.gethummans(command);
            float p = 0;
            float a = 0;
            float l = 0;
            string full = "";
            string fine = "";
            string cn = "";
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int absent = 0;
                int present = 0;
                int late = 0;
                 int presentc = 0;
                for (int j = 2; j < 9; j++)
                {
                    string[] attendance = h.GetSalaryDay(Convert.ToInt32(table.Rows[i][0]), j);
                    
                    for (int ii = 0; ii < attendance.Length; ii++)
                    {
                        if (attendance[ii] == "Present")
                        {
                            present++;
                            if (j == 8)
                            {
                                presentc++;
                            }
                        }
                        if (attendance[ii] == "Absent")
                        {
                            absent++;
                        }
                        if (attendance[ii] == "Late")
                        {
                            late++;
                        }
                    }
                }
                a += absent;
                p += present;
                l += late;
                SqlCommand command2= new SqlCommand("Select salary from employee where id = @id ");
                command2.Parameters.Add("@id", SqlDbType.NVarChar).Value = table.Rows[i][0];
                DataTable table2 = h.gethummans(command2);
                if(late+absent==0)
                {
                    full += table.Rows[i][1].ToString().Trim()+", ";
                }
                if(late+absent>5)
                {
                    fine += table.Rows[i][1].ToString().Trim() + ", ";
                }
                if(presentc>0)
                {
                    cn += table.Rows[i][1].ToString().Trim() + ", ";
                }
                dataGridView1.Rows.Add(table.Rows[i][0], table.Rows[i][1], late, absent, present, late * Global.LateSalary, (Convert.ToInt32(table2.Rows[0][0]) * 2 * presentc + (present + late) * Convert.ToInt32(table2.Rows[0][0]) - (late * Global.LateSalary)).ToString()+".000");
            }
            S0.Series["S0"].IsValueShownAsLabel = true;
            S0.Series["S0"].Points.AddXY("Absent", Convert.ToString(a*100/(a+p+l)));
            S0.Series["S0"].Points.AddXY("Present", Convert.ToString(p * 100 / (a + p + l)));
            S0.Series["S0"].Points.AddXY("Late", Convert.ToString(l * 100 / (a + p + l)));
            if(full.Trim()== "")
            {
                full = "Noone.,";
            }
            if (fine.Trim() == "")
            {
                fine = "Noone,.";
            }
            if (cn.Trim() == "")
            {
                cn = "Noone,.";
            }
            fulll.ForeColor = Color.Green;
            finee.ForeColor = Color.Red;
            cnn.ForeColor = Color.YellowGreen;
            fulll.Text = full.Trim().Substring(0, full.Length - 2);
            finee.Text = fine.Trim().Substring(0, fine.Length-2);
            cnn.Text = cn.Trim().Substring(0, cn.Length -2);
        }
        private void S0_Click(object sender, EventArgs e)
        {

        }

        private void btn_notice_Click(object sender, EventArgs e)
        {
            ChangeText f = new ChangeText();
            f.Show();
        }
    }
}
