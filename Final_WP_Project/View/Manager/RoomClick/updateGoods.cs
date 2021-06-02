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

namespace Final_WP_Project.View.Reception.RoomClick
{
    public partial class updateGoods : Form
    {
        public updateGoods()
        {
            InitializeComponent();
            save_btn.BackColor = Color.FromArgb(48, 182, 251);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            RoomFunction room = new RoomFunction();
            string name = food_cb.Text;
            int amount = Convert.ToInt32(amount_txt.Text);
            float unitprice = float.Parse(unitprice_txt.Text);

            if (Verify())
            {

                if (room.UpdateGood(name, amount, unitprice))
                {
                    MessageBox.Show("Update goods succesfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty fields", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            food_cb.Text = "";
            amount_txt.Text = "";
            unitprice_txt.Text = "";
            updateGoods_Load(sender, e);
        }
        public bool Verify()
        {
            if ((food_cb.Text.Trim() == "")
                || (amount_txt.Text.Trim() == "")
                || (unitprice_txt.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
          
        }

        private void updateGoods_Load(object sender, EventArgs e)
        {
            Human h = new Human();
            SqlCommand command = new SqlCommand("Select Goodid, name, amount, unitprice from Goods");
            DataTable table = h.gethummans(command);
            dataGridView1.DataSource = table;

           
            SqlCommand command1 = new SqlCommand("Select name from Goods");
            DataTable table1 = h.gethummans(command1);
            for(int i = 0;i < table1.Rows.Count;i++)
            {
                food_cb.Items.Add(table1.Rows[i][0].ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void unitprice_txt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double res = Convert.ToInt32(amount_txt.Text) * Convert.ToDouble(unitprice_txt.Text);
                totalprice_txt.Text = res.ToString() + ".000";
            }
            catch { }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void food_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
