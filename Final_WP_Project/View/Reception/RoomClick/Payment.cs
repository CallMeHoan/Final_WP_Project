using Final_WP_Project.Model;
using Final_WP_Project.Object;
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

namespace Final_WP_Project.View.Reception.Room
{
    public partial class Payment : Form
    {
        MY_DB mydb = new MY_DB();
        RoomFunction room = new RoomFunction();
        public Payment()
        {
            InitializeComponent();
            print_btn.BackColor = Color.FromArgb(48, 182, 251);
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            cusName_cb.Items.Clear();
            cusID_cb.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select Name from Customer");
            Human h = new Human();
            DataTable dt = h.gethummans(cmd);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                cusName_cb.Items.Add(dt.Rows[i][0]);
            }
            SqlCommand cmd1 = new SqlCommand("Select CustomerID from Customer");
            DataTable dt1 = h.gethummans(cmd1);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                cusID_cb.Items.Add(dt1.Rows[i][0]);
            }
        }

        void LoadData(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd);
            service_dgv.ReadOnly = true;
            service_dgv.DataSource = room.getService(command);
            service_dgv.AllowUserToAddRows = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cusID_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Load data
            string cmd = "Select * from Booking where CustomerID = '" + cusID_cb.Text + "'";
            SqlCommand command = new SqlCommand(cmd, mydb.getConnection);
            DataTable dt = new DataTable();
            Human h = new Human();
            dt = h.gethummans(command);

            string cmd3 = "Select Name from Customer where CustomerID = '" + cusID_cb.Text + "'";
            SqlCommand command1 = new SqlCommand(cmd3, mydb.getConnection);
            DataTable dt1 = h.gethummans(command1);
            cusName_cb.Text = dt1.Rows[0][0].ToString();

            roomID_txt.Text = dt.Rows[0][1].ToString();
            empID_txt.Text = dt.Rows[0][0].ToString();
            start_txt.Text = dt.Rows[0][3].ToString();
            end_txt.Text = dt.Rows[0][4].ToString();
            date_dtp.Text = dt.Rows[0][5].ToString();
            string cmd2 = "Select g.Name, sv.Amount, g.UnitPrice from Goods g, Service sv where g.GoodID = sv.GoodID and sv.CustomerID = '" + cusID_cb.Text + "' and sv.RoomID = '" + roomID_txt.Text + "'";
            LoadData(cmd2);


            //Total money
            TimeSpan starttime = TimeSpan.Parse(start_txt.Text);
            TimeSpan endtime = TimeSpan.Parse(end_txt.Text);
            TimeSpan time = endtime.Subtract(starttime);
            string formatTime = time.ToString();

            string[] subs = formatTime.Split(':');
            double hourtoDouble = Convert.ToDouble(subs[0]) + Convert.ToDouble(subs[1]) / 60 + Convert.ToDouble(subs[2]) / 3600;

            string money = "Select Price from Room where RoomID = '" + roomID_txt.Text + "'";

            SqlCommand cmdd = new SqlCommand(money, mydb.getConnection);
            DataTable dt2 = new DataTable();
            dt2 = h.gethummans(cmdd);
            roomMoney_txt.Text = (Convert.ToDouble(dt2.Rows[0][0]) * hourtoDouble).ToString();

            //Service money
            double serviceMoney = 0;
            for (int i = 0; i < service_dgv.Rows.Count; i++)
            {
                serviceMoney += Convert.ToInt32(service_dgv.Rows[i].Cells[1].Value.ToString()) * Convert.ToDouble(service_dgv.Rows[i].Cells[2].Value.ToString());
            }
            serviceMoney_txt.Text = serviceMoney.ToString();

            //Total money
            totalMoney_txt.Text = (Convert.ToDouble(roomMoney_txt.Text) + serviceMoney).ToString();
        }

        private void cusName_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Load data
            SqlCommand cmdd1 = new SqlCommand("Select CustomerID from Customer where Name = '" + cusName_cb.Text + "'", mydb.getConnection);
            Human h2 = new Human();
            DataTable dt2 = h2.gethummans(cmdd1);

            string cmd3 = "Select CustomerID from Customer where Name = '" + cusName_cb.Text + "'";
            SqlCommand command1 = new SqlCommand(cmd3, mydb.getConnection);
            DataTable dt1 = h2.gethummans(command1);
            cusID_cb.Text = dt1.Rows[0][0].ToString();

            string cmd = "Select * from Booking where CustomerID = '" + dt2.Rows[0][0].ToString() + "'";
            SqlCommand command = new SqlCommand(cmd, mydb.getConnection);
            DataTable dt = new DataTable();
            Human h = new Human();
            dt = h.gethummans(command);

            roomID_txt.Text = dt.Rows[0][1].ToString();
            empID_txt.Text = dt.Rows[0][0].ToString();
            start_txt.Text = dt.Rows[0][3].ToString();
            end_txt.Text = dt.Rows[0][4].ToString();
            date_dtp.Text = dt.Rows[0][5].ToString();
            string cmd2 = "Select g.Name, sv.Amount, g.UnitPrice from Goods g, Service sv where g.GoodID = sv.GoodID and sv.CustomerID = '" + cusID_cb.Text + "' and sv.RoomID = '" + roomID_txt.Text + "'";
            LoadData(cmd2);


            //Total money
            TimeSpan starttime = TimeSpan.Parse(start_txt.Text);
            TimeSpan endtime = TimeSpan.Parse(end_txt.Text);
            TimeSpan time = endtime.Subtract(starttime);
            string formatTime = time.ToString();

            string[] subs = formatTime.Split(':');
            double hourtoDouble = Convert.ToDouble(subs[0]) + Convert.ToDouble(subs[1]) / 60 + Convert.ToDouble(subs[2]) / 3600;

            string money = "Select Price from Room where RoomID = '" + roomID_txt.Text + "'";

            SqlCommand cmdd = new SqlCommand(money, mydb.getConnection);
            Human h1 = new Human();
            DataTable dt3 = h1.gethummans(cmdd);
            roomMoney_txt.Text = (Convert.ToDouble(dt3.Rows[0][0]) * hourtoDouble).ToString();

            //Service money
            double serviceMoney = 0;
            for (int i = 0; i < service_dgv.Rows.Count; i++)
            {
                serviceMoney += Convert.ToInt32(service_dgv.Rows[i].Cells[1].Value.ToString()) * Convert.ToDouble(service_dgv.Rows[i].Cells[2].Value.ToString());
            }
            serviceMoney_txt.Text = serviceMoney.ToString();

            //Total money
            totalMoney_txt.Text = (Convert.ToDouble(roomMoney_txt.Text) + serviceMoney).ToString();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            RoomFunction room = new RoomFunction();

            int rid = Convert.ToInt32(roomID_txt.Text);
            string cid = cusID_cb.Text;
            double service = Convert.ToDouble(serviceMoney_txt.Text);
            double roomMoney = Convert.ToDouble(roomMoney_txt.Text);
            double total = Convert.ToDouble(totalMoney_txt.Text);

            if (room.Bill(rid, cid, service, roomMoney, total))
            {
                MessageBox.Show("Check bill succesfully!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
