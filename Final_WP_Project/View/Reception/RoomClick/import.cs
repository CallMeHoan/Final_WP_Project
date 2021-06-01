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
    public partial class import : Form
    {
        public import()
        {
            InitializeComponent();
            save_btn.BackColor = Color.FromArgb(48, 182, 251);
            dataGridView1.AutoResizeColumns();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            RoomFunction room = new RoomFunction();
            string name = food_txt.Text;
            int amount = Convert.ToInt32(amount_txt.Text);
            float unitprice = float.Parse(unitprice_txt.Text);

            if (Verify())
            {

                if (room.Import(name, amount, unitprice))
                {
                    MessageBox.Show("Import goods succesfully!", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            food_txt.Text = "";
            amount_txt.Text = "";
            unitprice_txt.Text = "";
            totalprice_txt.Text = "";
            import_Load(sender, e);
        }
        public bool Verify()
        {
            if ((food_txt.Text.Trim() == "")
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

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void import_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_DatabaseDataSet.Goods' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'viduDataSet2.Goods' table. You can move, or remove it, as needed.
            Human h = new Human();
            SqlCommand command = new SqlCommand("Select Goodid, name, amount, unitprice from Goods");
            DataTable table = h.gethummans(command);
            dataGridView1.DataSource = table;

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
    }
}
