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
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace Final_WP_Project.View.Manager
{
    public partial class ReportClick : Form
    {
        public ReportClick()
        {
            InitializeComponent();
            Style();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            MainForm_Manager_ f = new MainForm_Manager_();
            this.Close();
            f.Show();
        }
        #region style
        public void Style()
        {
            //Color for label
            this.label2.ForeColor = Color.FromArgb(48, 182, 251);
            this.label3.ForeColor = Color.FromArgb(48, 182, 251);
            this.label4.ForeColor = Color.FromArgb(48, 182, 251);


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

        private void ReportClick_Load(object sender, EventArgs e)
        {
            if (Global.isManager == false)
            {
                reception_btn.Visible = false;
                static_btn.Visible = false;
            }
            Human h = new Human();
            SqlCommand command = new SqlCommand("Select * from employee where id = (Select id from login where account = @acc)");
            command.Parameters.Add("@acc", SqlDbType.NVarChar).Value = Global.GlobalId;
            DataTable table = h.gethummans(command);
            id_lb.Text =table.Rows[0][0].ToString();
            name_lb.Text = table.Rows[0][1].ToString();
            age_lb.Text = table.Rows[0][3].ToString();
            date_lb.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            time_lb.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            SqlCommand command1 = new SqlCommand("Select Sum(Service), Sum(roomprice), Sum(total) from bill");
            SqlCommand command2 = new SqlCommand("Select Sum(TotalPrice) from goods");
            DataTable table2 = h.gethummans(command2);
            DataTable table1 = h.gethummans(command1);
            vanguard_lb.Text = table1.Rows[0][1].ToString();
            goods_lb.Text = table2.Rows[0][0].ToString();
            soldGood_lb.Text = table1.Rows[0][0].ToString();
            string l = totalSalarry().ToString().Trim();
            paid_lb.Text = l+".000";
            total_lb.Text = ((Convert.ToDouble(vanguard_lb.Text) + Convert.ToDouble(soldGood_lb.Text)) - (Convert.ToDouble(goods_lb.Text) + Convert.ToDouble(l))).ToString() + ".000";
            
        }
        public float totalSalarry()
        {
            Human h = new Human();
            SqlCommand command = new SqlCommand("Select id, name from Employee");
            DataTable table = h.gethummans(command);
            float p = 0;
            float a = 0;
            float l = 0;
            float total = 0;
            string full = "";
            string fine = "";
            string cn = "";
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int absent = 0;
                int present = 0;
                int late = 0;
                int presentc = 0;
                for (int j = 2; j < 9; j++)
                {
                    string[] attendance = h.GetSalaryDay(Convert.ToInt32(table.Rows[i][0]), j);

                    for (int ii = 0; ii < attendance.Length; ii++)
                    {
                        if (attendance[ii] == "Present")
                        {
                            present++;
                            if (j == 8)
                            {
                                presentc++;
                            }
                        }
                        if (attendance[ii] == "Absent")
                        {
                            absent++;
                        }
                        if (attendance[ii] == "Late")
                        {
                            late++;
                        }
                    }
                }
                a += absent;
                p += present;
                l += late;
                SqlCommand command2 = new SqlCommand("Select salary from employee where id = @id ");
                command2.Parameters.Add("@id", SqlDbType.NVarChar).Value = table.Rows[i][0];
                DataTable table2 = h.gethummans(command2);
                if (late + absent == 0)
                {
                    full += table.Rows[i][1].ToString().Trim() + ", ";
                }
                if (late + absent > 5)
                {
                    fine += table.Rows[i][1].ToString().Trim() + ", ";
                }
                if (presentc > 0)
                {
                    cn += table.Rows[i][1].ToString().Trim() + ", ";
                }
              total += (Convert.ToInt32(table2.Rows[0][0]) * 2 * presentc + (present + late) * Convert.ToInt32(table2.Rows[0][0]) - (late * Global.LateSalary));
            }
            return total;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printPaycheck_btn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            using (DocX document = DocX.Create(@"D:\HelloWorldAddPictureToWord.docx"))
            {
                //Thêm các title
                Xceed.Document.NET.Paragraph title1 = document.InsertParagraph().AppendLine("--H&D Business Company--").Font("Arial").FontSize(17).Bold();
                title1.Alignment = Alignment.center;
                Xceed.Document.NET.Paragraph title = document.InsertParagraph().AppendLine("Week Report").Font("Poppins").FontSize(20).Bold();
                title.Alignment = Alignment.center;
                
             
                //Điếm Số lượng nữ(Chứa chữ F là nữa(Female))

                // Tạo 1 table có dòng bằng dòng datagridview và cột lớn hơn datagridview 1 cột để chứa headertext)
                Xceed.Document.NET.Table p2 = document.InsertTable(2, 2);
                //p2.Alignment = Alignment.center;
                p2.Rows[0].Cells[0].InsertParagraph().Append("   Information").Bold().Font("Poppins").FontSize(13) ;
                p2.Rows[0].Cells[1].InsertParagraph().Append("   Pay Check").Bold().Font("Poppins").FontSize(13);
                p2.Rows[1].Cells[0].InsertParagraph().Append("\t"+"UserID: " + id_lb.Text + "\n" + "\t"+ "Name: " + name_lb.Text + "\n" + "\t"+ "Age: " + age_lb.Text + "\n" + "\t" + "Date: " + date_lb.Text + "\n" + "\t" + "Current Time: "+time_lb.Text).FontSize(12).Font("Poppins");
                p2.Rows[1].Cells[1].InsertParagraph().Append("\t" + "Total Vanguard: " + vanguard_lb.Text + "\n" + "\t" + "Salary paid: " + paid_lb.Text + "\n" + "\t" + "Goods imported: " + goods_lb.Text + "\n" + "\t" + "Sold goods: " + soldGood_lb.Text + "\n" + "\t" + "Total: " + total_lb.Text).FontSize(12).Font("Poppins");
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
                //for (int i = 1; i < dataGridView1.Rows.Count + 1; i++)
                //{
                //    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                //    {
                //        //xử lý ảnh
                //        if (dataGridView1.Rows[i - 1].Cells[j].Value.GetType() == typeof(byte[]))
                //        {
                //            System.Drawing.Image image1 = byteArrayToImage((byte[])dataGridView1.Rows[i - 1].Cells[j].Value);
                //            image1.Save(@"D:\\test.PNG");
                //            var myImageFullPath = (@"D:\\test.PNG");
                //            Xceed.Document.NET.Image image = document.AddImage(myImageFullPath);
                //            Xceed.Document.NET.Picture picture = image.CreatePicture();
                //            picture.Height = 50;
                //            picture.Width = 50;
                //            p2.Rows[i].Cells[j + 1].InsertParagraph().AppendPicture(picture);
                //            File.Delete(@"D:\\test.PNG");
                //        }
                //        //xử lý text
                //        else

                //            p2.Rows[i].Cells[j + 1].InsertParagraph().Append(dataGridView1.Rows[i - 1].Cells[j].Value.ToString());

                //    }

                //}
                ////Thêm số thứ tự bằng vòng for
                //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                //{
                //    p2.Rows[i + 1].Cells[0].InsertParagraph().Append((i + 1).ToString());
                //}

                //Mở word lên và save
                document.Save();
                Microsoft.Office.Interop.Word.Application wor = new Microsoft.Office.Interop.Word.Application();
                wor.Visible = true;
                Microsoft.Office.Interop.Word.Document document0 = wor.Documents.OpenNoRepairDialog(@"D:\HelloWorldAddPictureToWord.docx");
                document0.Activate();
            }
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
            Close();
            DayOff f = new DayOff();
            f.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
