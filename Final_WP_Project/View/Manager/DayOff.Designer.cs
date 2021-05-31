
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.S0)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(23, 106);
            this.dataGridView1.Name = "dataGridView1";
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
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Late Day";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Absent Day";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Present Day";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fined Money";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total Salary";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // S0
            // 
            chartArea2.Name = "ChartArea1";
            this.S0.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.S0.Legends.Add(legend2);
            this.S0.Location = new System.Drawing.Point(23, 487);
            this.S0.Name = "S0";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "S0";
            this.S0.Series.Add(series2);
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
            // DayOff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 911);
            this.Controls.Add(this.cnn);
            this.Controls.Add(this.finee);
            this.Controls.Add(this.fulll);
            this.Controls.Add(this.lb_cn);
            this.Controls.Add(this.lb_fine);
            this.Controls.Add(this.lb_full);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.S0);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DayOff";
            this.Text = "DayOff";
            this.Load += new System.EventHandler(this.DayOff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.S0)).EndInit();
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
    }
}