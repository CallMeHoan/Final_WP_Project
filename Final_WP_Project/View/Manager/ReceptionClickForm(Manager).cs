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
           Human stdl = new Human();
            SqlCommand command = new SqlCommand("Select e.ID, e.Name, e.Phone, e.Salary, e.Age from Employee e where e.UserType = 'Reception';");
            dataGirdview_Reception.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGirdview_Reception.RowTemplate.Height = 200;
           

            DataTable table = stdl.gethummans(command);
            dataGirdview_Reception.DataSource = table;
          
            dataGirdview_Reception.AllowUserToAddRows = false;
            dataGirdview_Reception.AutoGenerateColumns = false;

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
    }
}
