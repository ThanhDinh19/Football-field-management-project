namespace QLSanBong
{
    partial class GiaoDienKH
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.btn_DatDV = new System.Windows.Forms.Button();
            this.btn_Datsan = new System.Windows.Forms.Button();
            this.btn_Photos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uC_ProfileKH1 = new QLSanBong.UC_Customer.UC_ProfileKH();
            this.uC_DatDichVu1 = new QLSanBong.UC_Customer.UC_DatDichVu();
            this.uC_DatSan1 = new QLSanBong.UC_Customer.UC_DatSan();
            this.uC_Images1 = new QLSanBong.UC_Customer.UC_Images();
            this.uC_Header1 = new QLSanBong.UC_Customer.uC_Header();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(31, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gia Phu Soccer Field";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Logout.Image = global::QLSanBong.Properties.Resources.result_logout;
            this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.Location = new System.Drawing.Point(152, 653);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(307, 56);
            this.btn_Logout.TabIndex = 14;
            this.btn_Logout.Text = "Log Out";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Profile
            // 
            this.btn_Profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Profile.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profile.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Profile.Image = global::QLSanBong.Properties.Resources.result_profile;
            this.btn_Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profile.Location = new System.Drawing.Point(152, 590);
            this.btn_Profile.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(307, 56);
            this.btn_Profile.TabIndex = 11;
            this.btn_Profile.Text = "View Profile";
            this.btn_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Profile.UseVisualStyleBackColor = false;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // btn_DatDV
            // 
            this.btn_DatDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_DatDV.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DatDV.ForeColor = System.Drawing.Color.DimGray;
            this.btn_DatDV.Image = global::QLSanBong.Properties.Resources.viewUSer_40px;
            this.btn_DatDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DatDV.Location = new System.Drawing.Point(152, 525);
            this.btn_DatDV.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DatDV.Name = "btn_DatDV";
            this.btn_DatDV.Size = new System.Drawing.Size(307, 56);
            this.btn_DatDV.TabIndex = 5;
            this.btn_DatDV.Text = "Add Service";
            this.btn_DatDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DatDV.UseVisualStyleBackColor = false;
            this.btn_DatDV.Click += new System.EventHandler(this.btn_DatDV_Click);
            // 
            // btn_Datsan
            // 
            this.btn_Datsan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Datsan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Datsan.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Datsan.Image = global::QLSanBong.Properties.Resources.result_add;
            this.btn_Datsan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Datsan.Location = new System.Drawing.Point(152, 460);
            this.btn_Datsan.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Datsan.Name = "btn_Datsan";
            this.btn_Datsan.Size = new System.Drawing.Size(307, 56);
            this.btn_Datsan.TabIndex = 6;
            this.btn_Datsan.Text = " Book Soccer Field";
            this.btn_Datsan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Datsan.UseVisualStyleBackColor = false;
            this.btn_Datsan.Click += new System.EventHandler(this.btn_Datsan_Click);
            // 
            // btn_Photos
            // 
            this.btn_Photos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Photos.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Photos.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Photos.Image = global::QLSanBong.Properties.Resources.result_picture;
            this.btn_Photos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Photos.Location = new System.Drawing.Point(152, 395);
            this.btn_Photos.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Photos.Name = "btn_Photos";
            this.btn_Photos.Size = new System.Drawing.Size(307, 56);
            this.btn_Photos.TabIndex = 7;
            this.btn_Photos.Text = "Soccer Field\'s Photo";
            this.btn_Photos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Photos.UseVisualStyleBackColor = false;
            this.btn_Photos.Click += new System.EventHandler(this.btn_Photos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSanBong.Properties.Resources.Cup;
            this.pictureBox1.Location = new System.Drawing.Point(110, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // uC_ProfileKH1
            // 
            this.uC_ProfileKH1.BackColor = System.Drawing.Color.White;
            this.uC_ProfileKH1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_ProfileKH1.Location = new System.Drawing.Point(450, 79);
            this.uC_ProfileKH1.Name = "uC_ProfileKH1";
            this.uC_ProfileKH1.Size = new System.Drawing.Size(1151, 651);
            this.uC_ProfileKH1.TabIndex = 15;
            // 
            // uC_DatDichVu1
            // 
            this.uC_DatDichVu1.BackColor = System.Drawing.Color.White;
            this.uC_DatDichVu1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_DatDichVu1.Location = new System.Drawing.Point(450, 79);
            this.uC_DatDichVu1.Name = "uC_DatDichVu1";
            this.uC_DatDichVu1.Size = new System.Drawing.Size(1123, 661);
            this.uC_DatDichVu1.TabIndex = 13;
            // 
            // uC_DatSan1
            // 
            this.uC_DatSan1.BackColor = System.Drawing.Color.White;
            this.uC_DatSan1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_DatSan1.Location = new System.Drawing.Point(450, 79);
            this.uC_DatSan1.Name = "uC_DatSan1";
            this.uC_DatSan1.Size = new System.Drawing.Size(1123, 663);
            this.uC_DatSan1.TabIndex = 12;
            // 
            // uC_Images1
            // 
            this.uC_Images1.BackColor = System.Drawing.Color.White;
            this.uC_Images1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_Images1.Location = new System.Drawing.Point(450, 79);
            this.uC_Images1.Name = "uC_Images1";
            this.uC_Images1.Size = new System.Drawing.Size(1133, 682);
            this.uC_Images1.TabIndex = 10;
            // 
            // uC_Header1
            // 
            this.uC_Header1.BackColor = System.Drawing.Color.IndianRed;
            this.uC_Header1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_Header1.Location = new System.Drawing.Point(-8, -6);
            this.uC_Header1.Name = "uC_Header1";
            this.uC_Header1.Size = new System.Drawing.Size(1581, 88);
            this.uC_Header1.TabIndex = 16;
            // 
            // GiaoDienKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1569, 718);
            this.Controls.Add(this.uC_Header1);
            this.Controls.Add(this.uC_ProfileKH1);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.uC_DatDichVu1);
            this.Controls.Add(this.uC_DatSan1);
            this.Controls.Add(this.btn_Profile);
            this.Controls.Add(this.uC_Images1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DatDV);
            this.Controls.Add(this.btn_Datsan);
            this.Controls.Add(this.btn_Photos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GiaoDienKH";
            this.Text = "GiaoDienKH";
            this.Load += new System.EventHandler(this.GiaoDienKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_DatDV;
        private System.Windows.Forms.Button btn_Datsan;
        private System.Windows.Forms.Button btn_Photos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UC_Customer.UC_Images uC_Images1;
        private System.Windows.Forms.Button btn_Profile;
        private UC_Customer.UC_DatSan uC_DatSan1;
        private UC_Customer.UC_DatDichVu uC_DatDichVu1;
        private System.Windows.Forms.Button btn_Logout;
        private UC_Customer.UC_ProfileKH uC_ProfileKH1;
        private UC_Customer.uC_Header uC_Header1;
    }
}