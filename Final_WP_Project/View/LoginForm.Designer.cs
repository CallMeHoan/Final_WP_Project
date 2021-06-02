
namespace Final_WP_Project.View
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.login_pn = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.submit_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.manager_rbtn = new System.Windows.Forms.RadioButton();
            this.yourAre_lb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.login_pn.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_pn
            // 
            this.login_pn.AutoSize = true;
            this.login_pn.BackColor = System.Drawing.Color.Transparent;
            this.login_pn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_pn.BackgroundImage")));
            this.login_pn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_pn.Controls.Add(this.panel3);
            this.login_pn.Controls.Add(this.panel2);
            this.login_pn.Controls.Add(this.panel1);
            this.login_pn.Controls.Add(this.radioButton1);
            this.login_pn.Controls.Add(this.manager_rbtn);
            this.login_pn.Controls.Add(this.yourAre_lb);
            this.login_pn.Cursor = System.Windows.Forms.Cursors.Default;
            this.login_pn.Location = new System.Drawing.Point(1163, 171);
            this.login_pn.Name = "login_pn";
            this.login_pn.Size = new System.Drawing.Size(654, 622);
            this.login_pn.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.BackgroundImage = global::Final_WP_Project.Properties.Resources.Picture11;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.submit_btn);
            this.panel3.Location = new System.Drawing.Point(212, 436);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 66);
            this.panel3.TabIndex = 11;
            // 
            // submit_btn
            // 
            this.submit_btn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.submit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit_btn.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.ForeColor = System.Drawing.Color.White;
            this.submit_btn.Location = new System.Drawing.Point(15, 9);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(203, 48);
            this.submit_btn.TabIndex = 5;
            this.submit_btn.Text = "Log in";
            this.submit_btn.UseVisualStyleBackColor = false;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BackgroundImage = global::Final_WP_Project.Properties.Resources.Picture31;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.password_txt);
            this.panel2.Location = new System.Drawing.Point(173, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 69);
            this.panel2.TabIndex = 10;
            // 
            // password_txt
            // 
            this.password_txt.AccessibleDescription = "";
            this.password_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_txt.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_txt.Location = new System.Drawing.Point(57, 16);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.password_txt.Size = new System.Drawing.Size(203, 38);
            this.password_txt.TabIndex = 3;
            this.password_txt.Text = "Password";
            this.password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_txt.Enter += new System.EventHandler(this.password_txt_Enter);
            this.password_txt.Leave += new System.EventHandler(this.password_txt_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BackgroundImage = global::Final_WP_Project.Properties.Resources.Picture31;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.userName_txt);
            this.panel1.Location = new System.Drawing.Point(173, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 69);
            this.panel1.TabIndex = 9;
            // 
            // userName_txt
            // 
            this.userName_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userName_txt.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_txt.Location = new System.Drawing.Point(57, 16);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.Size = new System.Drawing.Size(203, 38);
            this.userName_txt.TabIndex = 3;
            this.userName_txt.Text = "Username";
            this.userName_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userName_txt.Enter += new System.EventHandler(this.userName_txt_Enter);
            this.userName_txt.Leave += new System.EventHandler(this.userName_txt_Leave);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.Window;
            this.radioButton1.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(356, 73);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(169, 48);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Reception";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // manager_rbtn
            // 
            this.manager_rbtn.AutoSize = true;
            this.manager_rbtn.BackColor = System.Drawing.SystemColors.Window;
            this.manager_rbtn.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_rbtn.Location = new System.Drawing.Point(131, 73);
            this.manager_rbtn.Name = "manager_rbtn";
            this.manager_rbtn.Size = new System.Drawing.Size(158, 48);
            this.manager_rbtn.TabIndex = 7;
            this.manager_rbtn.TabStop = true;
            this.manager_rbtn.Text = "Manager";
            this.manager_rbtn.UseVisualStyleBackColor = false;
            // 
            // yourAre_lb
            // 
            this.yourAre_lb.AutoSize = true;
            this.yourAre_lb.BackColor = System.Drawing.SystemColors.Window;
            this.yourAre_lb.Font = new System.Drawing.Font("Poppins", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourAre_lb.Location = new System.Drawing.Point(220, 9);
            this.yourAre_lb.Name = "yourAre_lb";
            this.yourAre_lb.Size = new System.Drawing.Size(212, 76);
            this.yourAre_lb.TabIndex = 6;
            this.yourAre_lb.Text = "You are:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(772, 76);
            this.label5.TabIndex = 8;
            this.label5.Text = "your Hotel made by H.and.D group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(808, 76);
            this.label6.TabIndex = 7;
            this.label6.Text = "An application help you to manage ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Poppins", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 102);
            this.label7.TabIndex = 5;
            this.label7.Text = "Hotel";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Poppins", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(284, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(288, 102);
            this.label8.TabIndex = 6;
            this.label8.Text = "Manage";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.login_pn);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.login_pn.ResumeLayout(false);
            this.login_pn.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel login_pn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton manager_rbtn;
        private System.Windows.Forms.Label yourAre_lb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}