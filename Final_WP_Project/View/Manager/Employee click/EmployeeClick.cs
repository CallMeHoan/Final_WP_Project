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
    public partial class EmployeeClick : Form
    {
        public EmployeeClick()
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

        private void EmployeeClick_Load(object sender, EventArgs e)
        {
            Human stdl = new Human();
            SqlCommand command = new SqlCommand("Select e.ID, e.Name, e.Phone, e.Salary, e.Age from Employee e where e.UserType = 'Labor';");
            dgv_employee.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgv_employee.RowTemplate.Height = 200;


            DataTable table = stdl.gethummans(command);
            dgv_employee.DataSource = table;

            dgv_employee.AllowUserToAddRows = false;
            dgv_employee.AutoGenerateColumns = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClickAdd f = new ClickAdd();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Select_Employee f = new Select_Employee();
            f.Show();
        }

        private void dgv_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Human human = new Human();
            SqlCommand command = new SqlCommand("Select id, name, phone, age, usertype, gender from Employee where id = @id");
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = dgv_employee[0, e.RowIndex].Value.ToString();
            DataTable table = human.gethummans(command);
            int id; string name; int phone; string position; string gender; string age;
            id = Convert.ToInt32(table.Rows[0][0]);
            name = table.Rows[0][1].ToString();
            phone = Convert.ToInt32(table.Rows[0][2].ToString());
            age = table.Rows[0][3].ToString();
            position = table.Rows[0][4].ToString();
            gender = table.Rows[0][5].ToString();
            EditClick f = new EditClick(id, name, phone, position, gender, age);
            f.Show();
        }
    }
}
