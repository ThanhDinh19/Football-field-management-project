namespace QLSanBong.UC_Customer
{
    partial class UC_Images
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Previous = new System.Windows.Forms.PictureBox();
            this.btn_Next = new System.Windows.Forms.PictureBox();
            this.Img_SanBong = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Previous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_SanBong)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Previous
            // 
            this.btn_Previous.Image = global::QLSanBong.Properties.Resources.previous;
            this.btn_Previous.Location = new System.Drawing.Point(6, 282);
            this.btn_Previous.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(100, 77);
            this.btn_Previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Previous.TabIndex = 40;
            this.btn_Previous.TabStop = false;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click_1);
            this.btn_Previous.MouseLeave += new System.EventHandler(this.btn_Previous_MouseLeave);
            this.btn_Previous.MouseHover += new System.EventHandler(this.btn_Previous_MouseHover);
            // 
            // btn_Next
            // 
            this.btn_Next.Image = global::QLSanBong.Properties.Resources.next;
            this.btn_Next.Location = new System.Drawing.Point(993, 282);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(89, 77);
            this.btn_Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Next.TabIndex = 39;
            this.btn_Next.TabStop = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click_1);
            this.btn_Next.MouseLeave += new System.EventHandler(this.btn_Next_MouseLeave);
            this.btn_Next.MouseHover += new System.EventHandler(this.btn_Next_MouseHover);
            // 
            // Img_SanBong
            // 
            this.Img_SanBong.Image = global::QLSanBong.Properties.Resources.San6;
            this.Img_SanBong.Location = new System.Drawing.Point(125, 29);
            this.Img_SanBong.Margin = new System.Windows.Forms.Padding(4);
            this.Img_SanBong.Name = "Img_SanBong";
            this.Img_SanBong.Size = new System.Drawing.Size(849, 571);
            this.Img_SanBong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_SanBong.TabIndex = 38;
            this.Img_SanBong.TabStop = false;
            // 
            // UC_Images
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Previous);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.Img_SanBong);
            this.Name = "UC_Images";
            this.Size = new System.Drawing.Size(1133, 682);
            this.Load += new System.EventHandler(this.UC_Images_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Previous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_SanBong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Previous;
        private System.Windows.Forms.PictureBox btn_Next;
        private System.Windows.Forms.PictureBox Img_SanBong;
    }
}
