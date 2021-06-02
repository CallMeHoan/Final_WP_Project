
namespace Final_WP_Project.View.Reception.Room
{
    partial class Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.save_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.empID_txt = new System.Windows.Forms.TextBox();
            this.roomID_txt = new System.Windows.Forms.TextBox();
            this.start_txt = new System.Windows.Forms.TextBox();
            this.end_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.service_dgv = new System.Windows.Forms.DataGridView();
            this.date_dtp = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.roomMoney_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.serviceMoney_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.totalMoney_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cusName_cb = new System.Windows.Forms.ComboBox();
            this.cusID_cb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.service_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(1448, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.save_btn);
            this.panel2.Controls.Add(this.cancel_btn);
            this.panel2.Controls.Add(this.print_btn);
            this.panel2.Location = new System.Drawing.Point(-19, 652);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1972, 110);
            this.panel2.TabIndex = 66;
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Poppins", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(858, 31);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(200, 46);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Save changes";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancel_btn.Font = new System.Drawing.Font("Poppins", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(462, 31);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(123, 46);
            this.cancel_btn.TabIndex = 2;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // print_btn
            // 
            this.print_btn.Font = new System.Drawing.Font("Poppins", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.ForeColor = System.Drawing.Color.White;
            this.print_btn.Location = new System.Drawing.Point(625, 31);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(200, 46);
            this.print_btn.TabIndex = 1;
            this.print_btn.Text = "Print bill";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill check";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-41, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2067, 87);
            this.panel1.TabIndex = 63;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 44);
            this.label3.TabIndex = 67;
            this.label3.Text = "Room ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 44);
            this.label4.TabIndex = 68;
            this.label4.Text = "Customer ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 44);
            this.label5.TabIndex = 69;
            this.label5.Text = "Customer Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 44);
            this.label6.TabIndex = 70;
            this.label6.Text = "Start time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(490, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 44);
            this.label7.TabIndex = 71;
            this.label7.Text = "End time:";
            // 
            // empID_txt
            // 
            this.empID_txt.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empID_txt.Location = new System.Drawing.Point(222, 108);
            this.empID_txt.Multiline = true;
            this.empID_txt.Name = "empID_txt";
            this.empID_txt.Size = new System.Drawing.Size(123, 38);
            this.empID_txt.TabIndex = 72;
            // 
            // roomID_txt
            // 
            this.roomID_txt.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomID_txt.Location = new System.Drawing.Point(630, 108);
            this.roomID_txt.Multiline = true;
            this.roomID_txt.Name = "roomID_txt";
            this.roomID_txt.Size = new System.Drawing.Size(123, 38);
            this.roomID_txt.TabIndex = 73;
            // 
            // start_txt
            // 
            this.start_txt.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_txt.Location = new System.Drawing.Point(224, 308);
            this.start_txt.Multiline = true;
            this.start_txt.Name = "start_txt";
            this.start_txt.Size = new System.Drawing.Size(139, 38);
            this.start_txt.TabIndex = 76;
            // 
            // end_txt
            // 
            this.end_txt.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_txt.Location = new System.Drawing.Point(634, 308);
            this.end_txt.Multiline = true;
            this.end_txt.Name = "end_txt";
            this.end_txt.Size = new System.Drawing.Size(145, 38);
            this.end_txt.TabIndex = 77;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1022, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 44);
            this.label8.TabIndex = 78;
            this.label8.Text = "Service:";
            // 
            // service_dgv
            // 
            this.service_dgv.BackgroundColor = System.Drawing.Color.White;
            this.service_dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.service_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.service_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.service_dgv.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.service_dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.service_dgv.Location = new System.Drawing.Point(1031, 149);
            this.service_dgv.Name = "service_dgv";
            this.service_dgv.RowHeadersVisible = false;
            this.service_dgv.RowHeadersWidth = 51;
            this.service_dgv.RowTemplate.Height = 24;
            this.service_dgv.Size = new System.Drawing.Size(404, 220);
            this.service_dgv.TabIndex = 79;
            // 
            // date_dtp
            // 
            this.date_dtp.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_dtp.Location = new System.Drawing.Point(220, 394);
            this.date_dtp.Name = "date_dtp";
            this.date_dtp.Size = new System.Drawing.Size(396, 37);
            this.date_dtp.TabIndex = 100;
            this.date_dtp.Value = new System.DateTime(2021, 6, 1, 10, 45, 18, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(127, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 44);
            this.label9.TabIndex = 99;
            this.label9.Text = "Date:";
            // 
            // roomMoney_txt
            // 
            this.roomMoney_txt.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomMoney_txt.Location = new System.Drawing.Point(507, 583);
            this.roomMoney_txt.Multiline = true;
            this.roomMoney_txt.Name = "roomMoney_txt";
            this.roomMoney_txt.Size = new System.Drawing.Size(123, 38);
            this.roomMoney_txt.TabIndex = 102;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(306, 583);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 44);
            this.label10.TabIndex = 101;
            this.label10.Text = "Room charge:";
            // 
            // serviceMoney_txt
            // 
            this.serviceMoney_txt.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceMoney_txt.Location = new System.Drawing.Point(785, 583);
            this.serviceMoney_txt.Multiline = true;
            this.serviceMoney_txt.Name = "serviceMoney_txt";
            this.serviceMoney_txt.Size = new System.Drawing.Size(123, 38);
            this.serviceMoney_txt.TabIndex = 104;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(644, 583);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 44);
            this.label11.TabIndex = 103;
            this.label11.Text = "Services:";
            // 
            // totalMoney_txt
            // 
            this.totalMoney_txt.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMoney_txt.Location = new System.Drawing.Point(1038, 583);
            this.totalMoney_txt.Multiline = true;
            this.totalMoney_txt.Name = "totalMoney_txt";
            this.totalMoney_txt.Size = new System.Drawing.Size(123, 38);
            this.totalMoney_txt.TabIndex = 106;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(940, 583);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 44);
            this.label12.TabIndex = 105;
            this.label12.Text = "Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(663, 500);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 44);
            this.label13.TabIndex = 107;
            this.label13.Text = "Paycheck:";
            // 
            // cusName_cb
            // 
            this.cusName_cb.DisplayMember = "Name";
            this.cusName_cb.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusName_cb.FormattingEnabled = true;
            this.cusName_cb.Location = new System.Drawing.Point(634, 208);
            this.cusName_cb.Name = "cusName_cb";
            this.cusName_cb.Size = new System.Drawing.Size(323, 38);
            this.cusName_cb.TabIndex = 108;
            this.cusName_cb.ValueMember = "Name";
            this.cusName_cb.SelectedIndexChanged += new System.EventHandler(this.cusName_cb_SelectedIndexChanged);
            // 
            // cusID_cb
            // 
            this.cusID_cb.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusID_cb.FormattingEnabled = true;
            this.cusID_cb.Location = new System.Drawing.Point(220, 208);
            this.cusID_cb.Name = "cusID_cb";
            this.cusID_cb.Size = new System.Drawing.Size(125, 38);
            this.cusID_cb.TabIndex = 109;
            this.cusID_cb.SelectedIndexChanged += new System.EventHandler(this.cusID_cb_SelectedIndexChanged);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 758);
            this.Controls.Add(this.cusID_cb);
            this.Controls.Add(this.cusName_cb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.totalMoney_txt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.serviceMoney_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.roomMoney_txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.date_dtp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.service_dgv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.end_txt);
            this.Controls.Add(this.start_txt);
            this.Controls.Add(this.roomID_txt);
            this.Controls.Add(this.empID_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.service_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox empID_txt;
        private System.Windows.Forms.TextBox roomID_txt;
        private System.Windows.Forms.TextBox start_txt;
        private System.Windows.Forms.TextBox end_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView service_dgv;
        private System.Windows.Forms.DateTimePicker date_dtp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox roomMoney_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox serviceMoney_txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox totalMoney_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox cusName_cb;
        public System.Windows.Forms.ComboBox cusID_cb;
        private System.Windows.Forms.Button save_btn;
    }
}