using Final_WP_Project.View.Manager;
using Final_WP_Project.View.Manager.Employee_click;
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

namespace Final_WP_Project.View
{
    public partial class ReceptionClickForm_Manager_ : Form
    {
        public ReceptionClickForm_Manager_()
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
            NoBorderButton(static_btn);

        }
        public void NoBorderButton(Button a)
        {
            a.TabStop = false;
            a.FlatStyle = FlatStyle.Flat;
            a.FlatAppearance.BorderSize = 0;
        }
        #endregion

        private void ReceptionClickForm_Manager__Load(object sender, EventArgs e)
        {
            if (Global.isManager == false)
            {
                reception_btn.Visible = false;
                static_btn.Visible = false;
            }
            Human stdl = new Human();
            SqlCommand command = new SqlCommand("Select * from ViewReception;");
            dataGirdview_Reception.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGirdview_Reception.RowTemplate.Height = 200;
           

            DataTable table = stdl.gethummans(command);
            dataGirdview_Reception.DataSource = table;
          
            dataGirdview_Reception.AllowUserToAddRows = false;
            dataGirdview_Reception.AutoGenerateColumns = false;

            dataGirdview_Reception.Columns[0].Width = 160;
            dataGirdview_Reception.Columns[1].Width = 200;
            dataGirdview_Reception.Columns[2].Width = 200;
            dataGirdview_Reception.Columns[3].Width = 200;
            dataGirdview_Reception.Columns[4].Width = 200;

        }

        private void main_pn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            ClickAddButtonForm_Manager_ f = new ClickAddButtonForm_Manager_();
            f.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGirdview_Reception_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            Select_Employee f = new Select_Employee();
                        f.Show();
        }

        private void dataGirdview_Reception_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Human human = new Human();
            SqlCommand command = new SqlCommand("Select id, name, phone, age, usertype, gender from Employee where id = @id");
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = dataGirdview_Reception[0, e.RowIndex].Value.ToString();
            DataTable table = human.gethummans(command);
            int id; string name; int phone; string position; string gender; string age;
            id = Convert.ToInt32(table.Rows[0][0]);
            name = table.Rows[0][1].ToString();
            phone = Convert.ToInt32(table.Rows[0][2].ToString());
            age = table.Rows[0][3].ToString();
            position = table.Rows[0][4].ToString();
            gender = table.Rows[0][5].ToString();
            ReceptionLineClickForm_Manager_ f = new ReceptionLineClickForm_Manager_(id, name, phone, position, gender, age);
            f.Show();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            ReceptionClickForm_Manager__Load(sender, e);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            Select_Employee f = new Select_Employee();
            f.Show();
        }

        private void computeSalary_btn_Click(object sender, EventArgs e)
        {
            Select_Employee f = new Select_Employee();
            f.Show();
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
