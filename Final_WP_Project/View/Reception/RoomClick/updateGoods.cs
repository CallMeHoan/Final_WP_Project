using Final_WP_Project.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.goodsTableAdapter.Fill(this.viduDataSet1.Goods);
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
            // TODO: This line of code loads data into the 'viduDataSet1.Goods' table. You can move, or remove it, as needed.
            this.goodsTableAdapter.Fill(this.viduDataSet1.Goods);

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
    }
}
