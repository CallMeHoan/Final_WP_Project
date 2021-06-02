
namespace Final_WP_Project.View.Manager
{
    partial class DayOff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayOff));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S0 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_full = new System.Windows.Forms.Label();
            this.lb_fine = new System.Windows.Forms.Label();
            this.lb_cn = new System.Windows.Forms.Label();
            this.fulll = new System.Windows.Forms.Label();
            this.finee = new System.Windows.Forms.Label();
            this.cnn = new System.Windows.Forms.Label();
            this.btn_notice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.S0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(23, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1260, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Late Day";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Absent Day";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Present Day";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fined Money";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total Salary";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // S0
            // 
            chartArea1.Name = "ChartArea1";
            this.S0.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.S0.Legends.Add(legend1);
            this.S0.Location = new System.Drawing.Point(23, 487);
            this.S0.Name = "S0";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "S0";
            this.S0.Series.Add(series1);
            this.S0.Size = new System.Drawing.Size(416, 396);
            this.S0.TabIndex = 1;
            this.S0.Text = "chart1";
            this.S0.Click += new System.EventHandler(this.S0_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Static Manager";
            // 
            // lb_full
            // 
            this.lb_full.AutoSize = true;
            this.lb_full.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_full.Location = new System.Drawing.Point(515, 487);
            this.lb_full.Name = "lb_full";
            this.lb_full.Size = new System.Drawing.Size(340, 34);
            this.lb_full.TabIndex = 3;
            this.lb_full.Text = "Hard working(no absent or late): ";
            // 
            // lb_fine
            // 
            this.lb_fine.AutoSize = true;
            this.lb_fine.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fine.Location = new System.Drawing.Point(515, 557);
            this.lb_fine.Name = "lb_fine";
            this.lb_fine.Size = new System.Drawing.Size(419, 34);
            this.lb_fine.TabIndex = 4;
            this.lb_fine.Text = "Lazy employee(absent or late > 5 shifts):  ";
            // 
            // lb_cn
            // 
            this.lb_cn.AutoSize = true;
            this.lb_cn.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cn.Location = new System.Drawing.Point(515, 629);
            this.lb_cn.Name = "lb_cn";
            this.lb_cn.Size = new System.Drawing.Size(183, 34);
            this.lb_cn.TabIndex = 5;
            this.lb_cn.Text = "Work in Sunday:  ";
            // 
            // fulll
            // 
            this.fulll.AutoSize = true;
            this.fulll.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fulll.Location = new System.Drawing.Point(852, 487);
            this.fulll.Name = "fulll";
            this.fulll.Size = new System.Drawing.Size(47, 34);
            this.fulll.TabIndex = 6;
            this.fulll.Text = "full";
            // 
            // finee
            // 
            this.finee.AutoSize = true;
            this.finee.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finee.Location = new System.Drawing.Point(929, 557);
            this.finee.Name = "finee";
            this.finee.Size = new System.Drawing.Size(76, 34);
            this.finee.TabIndex = 7;
            this.finee.Text = "label2";
            // 
            // cnn
            // 
            this.cnn.AutoSize = true;
            this.cnn.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnn.Location = new System.Drawing.Point(692, 629);
            this.cnn.Name = "cnn";
            this.cnn.Size = new System.Drawing.Size(76, 34);
            this.cnn.TabIndex = 8;
            this.cnn.Text = "label3";
            // 
            // btn_notice
            // 
            this.btn_notice.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_notice.Location = new System.Drawing.Point(589, 801);
            this.btn_notice.Name = "btn_notice";
            this.btn_notice.Size = new System.Drawing.Size(266, 66);
            this.btn_notice.TabIndex = 9;
            this.btn_notice.Text = "Add Notification";
            this.btn_notice.UseVisualStyleBackColor = true;
            this.btn_notice.Click += new System.EventHandler(this.btn_notice_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(1243, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DayOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 995);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_notice);
            this.Controls.Add(this.cnn);
            this.Controls.Add(this.finee);
            this.Controls.Add(this.fulll);
            this.Controls.Add(this.lb_cn);
            this.Controls.Add(this.lb_fine);
            this.Controls.Add(this.lb_full);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.S0);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DayOff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DayOff";
            this.Load += new System.EventHandler(this.DayOff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.S0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataVisualization.Charting.Chart S0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_full;
        private System.Windows.Forms.Label lb_fine;
        private System.Windows.Forms.Label lb_cn;
        private System.Windows.Forms.Label fulll;
        private System.Windows.Forms.Label finee;
        private System.Windows.Forms.Label cnn;
        private System.Windows.Forms.Button btn_notice;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}