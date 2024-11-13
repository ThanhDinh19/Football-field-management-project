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
            this.btn_DatDV = new System.Windows.Forms.Button();
            this.btn_Datsan = new System.Windows.Forms.Button();
            this.btn_Photos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uC_Header1 = new QLSanBong.UC_Customer.uC_Header();
            this.uC_Images1 = new QLSanBong.UC_Customer.UC_Images();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gia Phu\'s Soccer Field";
            // 
            // btn_DatDV
            // 
            this.btn_DatDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_DatDV.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DatDV.ForeColor = System.Drawing.Color.DimGray;
            this.btn_DatDV.Image = global::QLSanBong.Properties.Resources.viewUSer_40px;
            this.btn_DatDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DatDV.Location = new System.Drawing.Point(131, 605);
            this.btn_DatDV.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DatDV.Name = "btn_DatDV";
            this.btn_DatDV.Size = new System.Drawing.Size(326, 56);
            this.btn_DatDV.TabIndex = 5;
            this.btn_DatDV.Text = "Add Service";
            this.btn_DatDV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DatDV.UseVisualStyleBackColor = false;
            // 
            // btn_Datsan
            // 
            this.btn_Datsan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Datsan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Datsan.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Datsan.Image = global::QLSanBong.Properties.Resources.addUser_40px;
            this.btn_Datsan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Datsan.Location = new System.Drawing.Point(131, 512);
            this.btn_Datsan.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Datsan.Name = "btn_Datsan";
            this.btn_Datsan.Size = new System.Drawing.Size(326, 56);
            this.btn_Datsan.TabIndex = 6;
            this.btn_Datsan.Text = "Book Soccer Field";
            this.btn_Datsan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Datsan.UseVisualStyleBackColor = false;
            // 
            // btn_Photos
            // 
            this.btn_Photos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Photos.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Photos.ForeColor = System.Drawing.Color.DimGray;
            this.btn_Photos.Image = global::QLSanBong.Properties.Resources.dashboard_40px;
            this.btn_Photos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Photos.Location = new System.Drawing.Point(131, 421);
            this.btn_Photos.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Photos.Name = "btn_Photos";
            this.btn_Photos.Size = new System.Drawing.Size(326, 56);
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
            // uC_Header1
            // 
            this.uC_Header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.uC_Header1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_Header1.Location = new System.Drawing.Point(-1, -1);
            this.uC_Header1.Name = "uC_Header1";
            this.uC_Header1.Size = new System.Drawing.Size(1574, 83);
            this.uC_Header1.TabIndex = 9;
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
            // GiaoDienKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1569, 718);
            this.Controls.Add(this.uC_Images1);
            this.Controls.Add(this.uC_Header1);
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
        private UC_Customer.uC_Header uC_Header1;
        private UC_Customer.UC_Images uC_Images1;
    }
}