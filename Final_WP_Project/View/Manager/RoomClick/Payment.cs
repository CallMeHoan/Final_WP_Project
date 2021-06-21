using Final_WP_Project.Model;
using Final_WP_Project.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

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
            Human h = new Human();
            roomID_txt.Text = Global.RoomID;
            SqlCommand newcmd = new SqlCommand("Select id from Login where Account = '" + Global.GlobalId + "'");
            DataTable dtt = h.gethummans(newcmd);
            empID_txt.Text = dtt.Rows[0][0].ToString();
            cusName_cb.Items.Clear();
            cusID_cb.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select Name from Customer");

            DataTable dt = h.gethummans(cmd);
            for (int i = 0; i < dt.Rows.Count; i++)
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
            start_txt.Text = dt.Rows[0][2].ToString();
            end_txt.Text = dt.Rows[0][3].ToString();
            date_dtp.Text = dt.Rows[0][4].ToString();
            string cmd2 = "Select g.Name, sv.Amount, g.UnitPrice from Goods g, Service sv where g.GoodID = sv.GoodID and sv.CustomerID = '" + cusID_cb.Text + "' and sv.RoomID = '" + roomID_txt.Text + "'";
            LoadData(cmd2);


            //Total money
            TimeSpan starttime = TimeSpan.Parse(start_txt.Text);
            TimeSpan endtime = TimeSpan.Parse(end_txt.Text);
            TimeSpan time = endtime.Subtract(starttime);
            string formatTime = time.ToString();

            string[] subs = formatTime.Split(':');
            double hourtoDouble = Convert.ToDouble(subs[0]) + Convert.ToDouble(subs[1]) / 60 + Convert.ToDouble(subs[2]) / 3600;

            string money = "Select Price from Room where ID = '" + roomID_txt.Text + "'";

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
          //  Payment_Load(sender, e);
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
            start_txt.Text = dt.Rows[0][2].ToString();
            end_txt.Text = dt.Rows[0][3].ToString();
            date_dtp.Text = dt.Rows[0][4].ToString();
            string cmd2 = "Select g.Name, sv.Amount, g.UnitPrice from Goods g, Service sv where g.GoodID = sv.GoodID and sv.CustomerID = '" + cusID_cb.Text + "' and sv.RoomID = '" + roomID_txt.Text + "'";
            LoadData(cmd2);


            //Total money
            TimeSpan starttime = TimeSpan.Parse(start_txt.Text);
            TimeSpan endtime = TimeSpan.Parse(end_txt.Text);
            TimeSpan time = endtime.Subtract(starttime);
            string formatTime = time.ToString();

            string[] subs = formatTime.Split(':');
            double hourtoDouble = Convert.ToDouble(subs[0]) + Convert.ToDouble(subs[1]) / 60 + Convert.ToDouble(subs[2]) / 3600;

            string money = "Select Price from Room where ID = '" + roomID_txt.Text + "'";

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
          //  Payment_Load(sender, e);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            RoomFunction room = new RoomFunction();

            string empID = empID_txt.Text;
            string rid = roomID_txt.Text;
            string cid = cusID_cb.Text;
            string start = start_txt.Text;
            string end = end_txt.Text;
            string date = date_dtp.Text;

            //Take time
            DateTime dt;
            if (!DateTime.TryParseExact(start, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
            {
                // handle validation error
            }
            TimeSpan StartTime = dt.TimeOfDay;

            DateTime time;
            if (!DateTime.TryParseExact(end, "HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out time))
            {
                // handle validation error
            }
            TimeSpan EndTime = time.TimeOfDay;

            CultureInfo culture = new CultureInfo("es-ES");
            DateTime newdate = DateTime.Parse(date, culture);
            string formatdate = newdate.ToString("yyyy-MM-dd");


            double service = Convert.ToDouble(serviceMoney_txt.Text);
            double roomMoney = Convert.ToDouble(roomMoney_txt.Text);
            double total = Convert.ToDouble(totalMoney_txt.Text);

            if (room.Bill(rid, cid, service, roomMoney, total))
            {
                room.UpdateBooking(empID, rid, cid, StartTime, EndTime, date);
                MessageBox.Show("Check bill succesfully!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void print_btn_Click(object sender, EventArgs e)
        {

            {
                using (DocX document = DocX.Create(@"D:\HelloWorldAddPictureToWord.docx"))
                {
                    //Thêm các title
                    Xceed.Document.NET.Paragraph title = document.InsertParagraph().AppendLine("H&G Business Comnany").Font("Poppins").FontSize(20).Bold();
                    title.Alignment = Alignment.center;
                    Xceed.Document.NET.Paragraph title1 = document.InsertParagraph().AppendLine("BILL\n").Font("Arial").FontSize(17).Bold();
                    title1.Alignment = Alignment.center;

                    //Điếm Số lượng nữ(Chứa chữ F là nữa(Female))
                    //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    //{
                    //    if (dataGridView1.Rows[i].Cells[4].Value.ToString().Contains('F')) f++;
                    //    else m++;
                    //}
                    //Xceed.Document.NET.Paragraph male = document.InsertParagraph().Append("Male Student: ").FontSize(13).Bold().Append(m.ToString()).FontSize(13);
                    //Xceed.Document.NET.Paragraph female = document.InsertParagraph().Append("Female Student: ").FontSize(13).Bold().Append(f.ToString()).FontSize(13);

                    //// Tạo 1 table có dòng bằng dòng datagridview và cột lớn hơn datagridview 1 cột để chứa headertext)
                    Xceed.Document.NET.Paragraph t1 = document.InsertParagraph().Append("Customer ID: " + cusID_cb.Text).Font("Poppins").FontSize(12).Bold();
                    Xceed.Document.NET.Paragraph t2 = document.InsertParagraph().Append("Customer Name: " + cusName_cb.Text).Font("Poppins").FontSize(12).Bold();
                    Xceed.Document.NET.Paragraph t3 = document.InsertParagraph().Append("Customer ID: " + empID_txt.Text + "\t" + "Room ID: " + roomID_txt.Text).Font("Poppins").FontSize(12).Bold();
                    Xceed.Document.NET.Paragraph t4 = document.InsertParagraph().Append("Start time: " + start_txt.Text + "\t" + "End Time: " + end_txt.Text).Font("Poppins").FontSize(12).Bold();
                    Xceed.Document.NET.Paragraph t5 = document.InsertParagraph().Append("Date: " + date_dtp.Text).Font("Poppins").FontSize(12).Bold();
                    Xceed.Document.NET.Table p2 = document.InsertTable(service_dgv.Rows.Count + 1, service_dgv.Columns.Count + 1);
                    p2.Alignment = Alignment.center;

                    Xceed.Document.NET.Paragraph t6 = document.InsertParagraph().AppendLine(" Room charge:    \t" + roomMoney_txt.Text + "\n" + "\t               +" + "\n" + " Service:\t              " + serviceMoney_txt.Text + "\n" + "------------------------------" + "\n" +"Total: "+ "\t             " + (Convert.ToDouble(roomMoney_txt.Text) + Convert.ToDouble(serviceMoney_txt.Text)).ToString()).Font("Poppins").FontSize(12).Bold();
                    Xceed.Document.NET.Paragraph t7 = document.InsertParagraph().Append("Have a good day, Thanks!").Font("Poppins").FontSize(12).Bold();
                    t6.Alignment = Alignment.center;
                    t7.Alignment = Alignment.center;
                    p2.Rows[0].Cells[1].InsertParagraph().Append("Name").Bold();
                    p2.Rows[0].Cells[2].InsertParagraph().Append("Amount").Bold();
                    p2.Rows[0].Cells[3].InsertParagraph().Append("Total Money").Bold();
                    p2.Rows[0].Cells[0].InsertParagraph().Append("Number").Bold();
                    ////tạo headertext
                    //p2.Rows[0].Cells[1].InsertParagraph().Append("ID");
                    //p2.Rows[0].Cells[2].InsertParagraph().Append("First Name");
                    //p2.Rows[0].Cells[3].InsertParagraph().Append("Last Name");
                    //p2.Rows[0].Cells[4].InsertParagraph().Append("BirthDay");
                    //p2.Rows[0].Cells[5].InsertParagraph().Append("Gender");
                    //p2.Rows[0].Cells[6].InsertParagraph().Append("Phone");
                    //p2.Rows[0].Cells[7].InsertParagraph().Append("Address");
                    //p2.Rows[0].Cells[8].InsertParagraph().Append("Avatar");
                    //p2.Rows[0].Cells[0].InsertParagraph().Append("Number");

                    ////Dùng 2 vòng for để đổ dữ liệu vào word
                    for (int i = 1; i < service_dgv.Rows.Count + 1; i++)
                    {
                        for (int j = 0; j < service_dgv.Columns.Count; j++)
                        {


                            p2.Rows[i].Cells[j + 1].InsertParagraph().Append(service_dgv.Rows[i - 1].Cells[j].Value.ToString());

                        }

                    }
                    //Thêm số thứ tự bằng vòng for
                    for (int i = 0; i < service_dgv.Rows.Count; i++)
                    {
                        p2.Rows[i + 1].Cells[0].InsertParagraph().Append((i + 1).ToString());
                    }

                    //Mở word lên và save
                    document.Save();
                    Microsoft.Office.Interop.Word.Application wor = new Microsoft.Office.Interop.Word.Application();
                    wor.Visible = true;
                    Microsoft.Office.Interop.Word.Document document0 = wor.Documents.OpenNoRepairDialog(@"D:\HelloWorldAddPictureToWord.docx");
                    document0.Activate();
                }
            }
        }

    } 
    
}
