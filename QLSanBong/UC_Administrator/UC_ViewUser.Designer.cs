namespace QLSanBong.UC_Administrator
{
    partial class UC_ViewUser
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
            this.dgv_Employee = new System.Windows.Forms.DataGridView();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.picture_Emp = new System.Windows.Forms.PictureBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Refresh = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Emp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_find)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Employee
            // 
            this.dgv_Employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee.Location = new System.Drawing.Point(21, 232);
            this.dgv_Employee.Name = "dgv_Employee";
            this.dgv_Employee.ReadOnly = true;
            this.dgv_Employee.RowHeadersWidth = 51;
            this.dgv_Employee.RowTemplate.Height = 24;
            this.dgv_Employee.Size = new System.Drawing.Size(1091, 478);
            this.dgv_Employee.TabIndex = 12;
            this.dgv_Employee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Employee_CellClick);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(357, 160);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(430, 54);
            this.txt_Search.TabIndex = 13;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // picture_Emp
            // 
            this.picture_Emp.Location = new System.Drawing.Point(940, 28);
            this.picture_Emp.Name = "picture_Emp";
            this.picture_Emp.Size = new System.Drawing.Size(172, 194);
            this.picture_Emp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_Emp.TabIndex = 18;
            this.picture_Emp.TabStop = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Image = global::QLSanBong.Properties.Resources.delete_40px;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(958, 748);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(146, 64);
            this.btn_Delete.TabIndex = 17;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Image = global::QLSanBong.Properties.Resources.edit_40;
            this.btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.Location = new System.Drawing.Point(777, 748);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(146, 64);
            this.btn_Edit.TabIndex = 16;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_find
            // 
            this.btn_find.Image = global::QLSanBong.Properties.Resources._470206;
            this.btn_find.Location = new System.Drawing.Point(729, 162);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(57, 50);
            this.btn_find.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_find.TabIndex = 15;
            this.btn_find.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSanBong.Properties.Resources.view;
            this.pictureBox1.Location = new System.Drawing.Point(3, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Image = global::QLSanBong.Properties.Resources.sync_64px;
            this.btn_Refresh.Location = new System.Drawing.Point(227, 46);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(61, 61);
            this.btn_Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.TabStop = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLSanBong.Properties.Resources.sync;
            this.pictureBox2.Location = new System.Drawing.Point(201, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // UC_ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picture_Emp);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dgv_Employee);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UC_ViewUser";
            this.Size = new System.Drawing.Size(1136, 860);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Emp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_find)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_Refresh;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_Employee;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.PictureBox btn_find;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.PictureBox picture_Emp;
    }
}
