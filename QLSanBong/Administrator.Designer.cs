namespace QLSanBong
{
    partial class Administrator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.btn_ViewUser = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uC_AddUser1 = new QLSanBong.UC_Administrator.UC_AddUser();
            this.uC_Dashboard1 = new QLSanBong.UC_Administrator.UC_Dashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_LogOut);
            this.panel1.Controls.Add(this.btn_Profile);
            this.panel1.Controls.Add(this.btn_ViewUser);
            this.panel1.Controls.Add(this.btn_AddUser);
            this.panel1.Controls.Add(this.btn_Dashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 860);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 800);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(80, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Administrator";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_AddUser1);
            this.panel2.Controls.Add(this.uC_Dashboard1);
            this.panel2.Location = new System.Drawing.Point(423, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1136, 860);
            this.panel2.TabIndex = 1;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_LogOut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.DimGray;
            this.btn_LogOut.Image = global::QLSanBong.Properties.Resources.logOut_40px;
            this.btn_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LogOut.Location = new System.Drawing.Point(174, 705);
            this.btn_LogOut.Margin = new System.Windows.Forms.Padding(0);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(249, 56);
            this.btn_LogOut.TabIndex = 1;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_Profile
            // 
            this.btn_Profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Profile.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profile.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Profile.Image = global::QLSanBong.Properties.Resources.profile_40px;
            this.btn_Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profile.Location = new System.Drawing.Point(174, 614);
            this.btn_Profile.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(249, 56);
            this.btn_Profile.TabIndex = 1;
            this.btn_Profile.Text = "Profile";
            this.btn_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Profile.UseVisualStyleBackColor = false;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // btn_ViewUser
            // 
            this.btn_ViewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_ViewUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewUser.ForeColor = System.Drawing.Color.DimGray;
            this.btn_ViewUser.Image = global::QLSanBong.Properties.Resources.viewUSer_40px;
            this.btn_ViewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ViewUser.Location = new System.Drawing.Point(174, 523);
            this.btn_ViewUser.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ViewUser.Name = "btn_ViewUser";
            this.btn_ViewUser.Size = new System.Drawing.Size(249, 56);
            this.btn_ViewUser.TabIndex = 1;
            this.btn_ViewUser.Text = "View User";
            this.btn_ViewUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ViewUser.UseVisualStyleBackColor = false;
            this.btn_ViewUser.Click += new System.EventHandler(this.btn_ViewUser_Click);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_AddUser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddUser.ForeColor = System.Drawing.Color.DimGray;
            this.btn_AddUser.Image = global::QLSanBong.Properties.Resources.addUser_40px;
            this.btn_AddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddUser.Location = new System.Drawing.Point(174, 433);
            this.btn_AddUser.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(249, 56);
            this.btn_AddUser.TabIndex = 1;
            this.btn_AddUser.Text = "Add User";
            this.btn_AddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddUser.UseVisualStyleBackColor = false;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Dashboard.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Dashboard.Image = global::QLSanBong.Properties.Resources.dashboard_40px;
            this.btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.Location = new System.Drawing.Point(174, 343);
            this.btn_Dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(249, 56);
            this.btn_Dashboard.TabIndex = 1;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSanBong.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(95, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uC_AddUser1
            // 
            this.uC_AddUser1.BackColor = System.Drawing.Color.White;
            this.uC_AddUser1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddUser1.Name = "uC_AddUser1";
            this.uC_AddUser1.Size = new System.Drawing.Size(1136, 860);
            this.uC_AddUser1.TabIndex = 1;
            this.uC_AddUser1.Load += new System.EventHandler(this.uC_AddUser1_Load);
            // 
            // uC_Dashboard1
            // 
            this.uC_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_Dashboard1.Location = new System.Drawing.Point(0, 2);
            this.uC_Dashboard1.Name = "uC_Dashboard1";
            this.uC_Dashboard1.Size = new System.Drawing.Size(1133, 857);
            this.uC_Dashboard1.TabIndex = 0;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1559, 862);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Administrator";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Profile;
        private System.Windows.Forms.Button btn_ViewUser;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private UC_Administrator.UC_Dashboard uC_Dashboard1;
        private UC_Administrator.UC_AddUser uC_AddUser1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}