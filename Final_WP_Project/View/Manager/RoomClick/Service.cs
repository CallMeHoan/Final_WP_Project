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
    public partial class Service : Form
    {
        RoomFunction room = new RoomFunction();
        string rid;
        string cid;
        bool have = false;
        public Service(string roomid, string cusid)
        {
            InitializeComponent();
            rid = roomid;
            cid = cusid;
        }
        public Service()
        {
            InitializeComponent();
            add_btn.BackColor = Color.FromArgb(48, 182, 251);
            showService_dgv.AutoResizeColumns();
        }
        public void add_btn_Click(object sender, EventArgs e)
        {
            have = true;
            int amount = Convert.ToInt32(amount_txt.Text);
            SqlCommand command = new SqlCommand("Select Goodid from goods where name = '" + food_cb.Text + "'");
            Human h = new Human();
            DataTable table = h.gethummans(command);
            string gid = table.Rows[0][0].ToString();

            if (Verify())
            {

                if (room.NewService(rid, cid, gid, amount))
                {
                    MessageBox.Show("Add goods succesfully!", "Service", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error!", "Import", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Import", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            food_cb.Text = "";
            amount_txt.Text = "";
            unitprice_txt.Text = "";
            total_txt.Text = "";
            string cmd = "Select g.Name, sv.Amount, g.UnitPrice from Goods g, Service sv where g.GoodID = sv.GoodID and sv.CustomerID = '" + cid + "' and sv.RoomID = '" + rid + "'";
            LoadData(cmd);
        }
        public bool Verify()
        {
            if ((food_cb.Text.Trim() == "")
                || (amount_txt.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        //Function
        private void close_btn_Click(object sender, EventArgs e)
        {
            if (have == true)
            {
                if (room.deleteService(rid, cid))
                {
                    MessageBox.Show("Do you want to leave without saving changes?", "Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("Can't do this right now", "Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int x = showService_dgv.Rows.Count;
            if (room.deleteService(cid, rid))
            {
                MessageBox.Show("Do you want to leave without saving changes?", "Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("Can't do this right now", "Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        private void Service_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'viduDataSet2.Goods' table. You can move, or remove it, as needed.
            SqlCommand command = new SqlCommand("Select Name from Goods");
            Human h = new Human();
            DataTable table = h.gethummans(command);
            for(int i = 0; i < table.Rows.Count;i++)
            {
                food_cb.Items.Add(table.Rows[i][0].ToString());
            }

        }
        void LoadData(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd);
            showService_dgv.ReadOnly = true;
            showService_dgv.DataSource = room.getService(command);
            showService_dgv.AllowUserToAddRows = false;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            RoomFunction room = new RoomFunction();
            int totalRow = showService_dgv.Rows.Count;
            string[] name = new string[totalRow];
            int[] amount = new int[totalRow];
            for (int i = 0; i < totalRow; i++)
            {
                name[i] = showService_dgv.Rows[i].Cells[0].Value.ToString();
                amount[i] = Convert.ToInt32(showService_dgv.Rows[i].Cells[1].Value.ToString());
            }
            for (int i = 0; i < showService_dgv.Rows.Count; i++)
            {
                if (room.UpdateAmountGood(name[i], amount[i]))
                {
                    MessageBox.Show("Add service succesfully!", "Service", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error!", "Service", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void food_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select Unitprice from goods where name = '"+food_cb.Text+"'");
            Human h = new Human();
            DataTable table = h.gethummans(command);
            unitprice_txt.Text = table.Rows[0][0].ToString();
        }

        private void showService_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void amount_txt_TextChanged(object sender, EventArgs e)
        {
            total_txt.Text = "";
            if (amount_txt.Text != "")
            {
                total_txt.Text = (Convert.ToDouble(amount_txt.Text) * Convert.ToDouble(unitprice_txt.Text)).ToString()+".0000";
            }
            else
            {
                total_txt.Text = "0";
            }
        }
    }
}
