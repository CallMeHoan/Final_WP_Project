using Final_WP_Project.View;
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

namespace Final_WP_Project
{
    public partial class Select_Employee : Form
    {
        public Select_Employee()
        {
            InitializeComponent();
        }

        private void Select_Employee_Load(object sender, EventArgs e)
        {

            Human h = new Human();
            SqlCommand command = new SqlCommand("Select id, name from employee");
            DataTable table = h.gethummans(command);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cbb_Select.Items.Add("ID: " + table.Rows[i][0].ToString().Trim() + " | Name: " + table.Rows[i][1].ToString().Trim());
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Human human = new Human();
            int index = (cbb_Select.SelectedItem.ToString()).IndexOf("|");
            string a = (cbb_Select.SelectedItem.ToString()).Substring(3, index - 3);
           
            SqlCommand command = new SqlCommand("Select id, name, phone, age, usertype, gender from Employee where id = @id");
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = a.Trim();
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

        private void cbb_Select_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
