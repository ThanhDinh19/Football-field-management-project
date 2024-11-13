namespace QLSanBong.UC_Administrator
{
    partial class UC_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Profile));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo_suspended = new System.Windows.Forms.RadioButton();
            this.rdo_locked = new System.Windows.Forms.RadioButton();
            this.rdo_active = new System.Windows.Forms.RadioButton();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureEmployee = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowHide = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdo_Other = new System.Windows.Forms.RadioButton();
            this.rdo_Male = new System.Windows.Forms.RadioButton();
            this.rdo_Female = new System.Windows.Forms.RadioButton();
            this.cbo_Position = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.CardPhoto = new System.Windows.Forms.PictureBox();
            this.btn_ChooseImg = new System.Windows.Forms.Button();
            this.txt_Fullname = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.labelPhonenumber = new System.Windows.Forms.Label();
            this.txt_Phonenumber = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.txt_Salary = new System.Windows.Forms.TextBox();
            this.labelFullname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmployee)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowHide)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_suspended);
            this.groupBox2.Controls.Add(this.rdo_locked);
            this.groupBox2.Controls.Add(this.rdo_active);
            this.groupBox2.Location = new System.Drawing.Point(36, 526);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 44);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // rdo_suspended
            // 
            this.rdo_suspended.AutoSize = true;
            this.rdo_suspended.Location = new System.Drawing.Point(259, 18);
            this.rdo_suspended.Name = "rdo_suspended";
            this.rdo_suspended.Size = new System.Drawing.Size(98, 20);
            this.rdo_suspended.TabIndex = 28;
            this.rdo_suspended.TabStop = true;
            this.rdo_suspended.Text = "Suspended";
            this.rdo_suspended.UseVisualStyleBackColor = true;
            // 
            // rdo_locked
            // 
            this.rdo_locked.AutoSize = true;
            this.rdo_locked.Location = new System.Drawing.Point(135, 18);
            this.rdo_locked.Name = "rdo_locked";
            this.rdo_locked.Size = new System.Drawing.Size(73, 20);
            this.rdo_locked.TabIndex = 27;
            this.rdo_locked.TabStop = true;
            this.rdo_locked.Text = "Locked";
            this.rdo_locked.UseVisualStyleBackColor = true;
            // 
            // rdo_active
            // 
            this.rdo_active.AutoSize = true;
            this.rdo_active.Location = new System.Drawing.Point(10, 18);
            this.rdo_active.Name = "rdo_active";
            this.rdo_active.Size = new System.Drawing.Size(65, 20);
            this.rdo_active.TabIndex = 26;
            this.rdo_active.TabStop = true;
            this.rdo_active.Text = "Active";
            this.rdo_active.UseVisualStyleBackColor = true;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(161, 492);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(117, 31);
            this.labelUsername.TabIndex = 56;
            this.labelUsername.Text = "Username";
            // 
            // pictureEmployee
            // 
            this.pictureEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureEmployee.Image = global::QLSanBong.Properties.Resources.noUserImage;
            this.pictureEmployee.Location = new System.Drawing.Point(109, 244);
            this.pictureEmployee.Name = "pictureEmployee";
            this.pictureEmployee.Size = new System.Drawing.Size(232, 245);
            this.pictureEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEmployee.TabIndex = 55;
            this.pictureEmployee.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowHide);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.cbo_Position);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txt_Fullname);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.labelPassword);
            this.groupBox1.Controls.Add(this.labelSalary);
            this.groupBox1.Controls.Add(this.txt_Address);
            this.groupBox1.Controls.Add(this.labelPhonenumber);
            this.groupBox1.Controls.Add(this.txt_Phonenumber);
            this.groupBox1.Controls.Add(this.labelAddress);
            this.groupBox1.Controls.Add(this.txt_Salary);
            this.groupBox1.Controls.Add(this.labelFullname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(454, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 592);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // ShowHide
            // 
            this.ShowHide.Image = global::QLSanBong.Properties.Resources.hide_passw_40px1;
            this.ShowHide.Location = new System.Drawing.Point(295, 513);
            this.ShowHide.Name = "ShowHide";
            this.ShowHide.Size = new System.Drawing.Size(47, 44);
            this.ShowHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowHide.TabIndex = 52;
            this.ShowHide.TabStop = false;
            this.ShowHide.Click += new System.EventHandler(this.ShowHide_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdo_Other);
            this.groupBox4.Controls.Add(this.rdo_Male);
            this.groupBox4.Controls.Add(this.rdo_Female);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(40, 412);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(302, 58);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gender";
            // 
            // rdo_Other
            // 
            this.rdo_Other.AutoSize = true;
            this.rdo_Other.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Other.Location = new System.Drawing.Point(210, 24);
            this.rdo_Other.Name = "rdo_Other";
            this.rdo_Other.Size = new System.Drawing.Size(72, 24);
            this.rdo_Other.TabIndex = 48;
            this.rdo_Other.TabStop = true;
            this.rdo_Other.Text = "Other";
            this.rdo_Other.UseVisualStyleBackColor = true;
            // 
            // rdo_Male
            // 
            this.rdo_Male.AutoSize = true;
            this.rdo_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Male.Location = new System.Drawing.Point(18, 24);
            this.rdo_Male.Name = "rdo_Male";
            this.rdo_Male.Size = new System.Drawing.Size(66, 24);
            this.rdo_Male.TabIndex = 47;
            this.rdo_Male.TabStop = true;
            this.rdo_Male.Text = "Male";
            this.rdo_Male.UseVisualStyleBackColor = true;
            // 
            // rdo_Female
            // 
            this.rdo_Female.AutoSize = true;
            this.rdo_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Female.Location = new System.Drawing.Point(108, 24);
            this.rdo_Female.Name = "rdo_Female";
            this.rdo_Female.Size = new System.Drawing.Size(91, 24);
            this.rdo_Female.TabIndex = 48;
            this.rdo_Female.TabStop = true;
            this.rdo_Female.Text = "Fe-Male";
            this.rdo_Female.UseVisualStyleBackColor = true;
            // 
            // cbo_Position
            // 
            this.cbo_Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Position.FormattingEnabled = true;
            this.cbo_Position.Location = new System.Drawing.Point(263, 342);
            this.cbo_Position.Name = "cbo_Position";
            this.cbo_Position.Size = new System.Drawing.Size(346, 33);
            this.cbo_Position.TabIndex = 50;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Clear);
            this.groupBox3.Controls.Add(this.CardPhoto);
            this.groupBox3.Controls.Add(this.btn_ChooseImg);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(384, 412);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 153);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Card Photo";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear.Image")));
            this.btn_Clear.Location = new System.Drawing.Point(170, 92);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(49, 45);
            this.btn_Clear.TabIndex = 48;
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // CardPhoto
            // 
            this.CardPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardPhoto.Location = new System.Drawing.Point(19, 22);
            this.CardPhoto.Name = "CardPhoto";
            this.CardPhoto.Size = new System.Drawing.Size(131, 125);
            this.CardPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CardPhoto.TabIndex = 46;
            this.CardPhoto.TabStop = false;
            // 
            // btn_ChooseImg
            // 
            this.btn_ChooseImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChooseImg.ForeColor = System.Drawing.Color.Black;
            this.btn_ChooseImg.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChooseImg.Image")));
            this.btn_ChooseImg.Location = new System.Drawing.Point(170, 36);
            this.btn_ChooseImg.Name = "btn_ChooseImg";
            this.btn_ChooseImg.Size = new System.Drawing.Size(49, 45);
            this.btn_ChooseImg.TabIndex = 47;
            this.btn_ChooseImg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ChooseImg.UseVisualStyleBackColor = true;
            this.btn_ChooseImg.Click += new System.EventHandler(this.btn_ChooseImg_Click);
            // 
            // txt_Fullname
            // 
            this.txt_Fullname.Location = new System.Drawing.Point(263, 32);
            this.txt_Fullname.Multiline = true;
            this.txt_Fullname.Name = "txt_Fullname";
            this.txt_Fullname.Size = new System.Drawing.Size(346, 44);
            this.txt_Fullname.TabIndex = 33;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(40, 513);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(249, 44);
            this.txt_Password.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(34, 482);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 31);
            this.label15.TabIndex = 47;
            this.label15.Text = "Password";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(39, 557);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 16);
            this.labelPassword.TabIndex = 44;
            this.labelPassword.Text = "notification";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(260, 304);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(70, 16);
            this.labelSalary.TabIndex = 44;
            this.labelSalary.Text = "notification";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(263, 181);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(346, 44);
            this.txt_Address.TabIndex = 32;
            // 
            // labelPhonenumber
            // 
            this.labelPhonenumber.AutoSize = true;
            this.labelPhonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhonenumber.Location = new System.Drawing.Point(260, 153);
            this.labelPhonenumber.Name = "labelPhonenumber";
            this.labelPhonenumber.Size = new System.Drawing.Size(70, 16);
            this.labelPhonenumber.TabIndex = 44;
            this.labelPhonenumber.Text = "notification";
            // 
            // txt_Phonenumber
            // 
            this.txt_Phonenumber.Location = new System.Drawing.Point(263, 106);
            this.txt_Phonenumber.Multiline = true;
            this.txt_Phonenumber.Name = "txt_Phonenumber";
            this.txt_Phonenumber.Size = new System.Drawing.Size(346, 44);
            this.txt_Phonenumber.TabIndex = 31;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(260, 228);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(70, 16);
            this.labelAddress.TabIndex = 44;
            this.labelAddress.Text = "notification";
            // 
            // txt_Salary
            // 
            this.txt_Salary.Enabled = false;
            this.txt_Salary.Location = new System.Drawing.Point(263, 258);
            this.txt_Salary.Multiline = true;
            this.txt_Salary.Name = "txt_Salary";
            this.txt_Salary.Size = new System.Drawing.Size(346, 44);
            this.txt_Salary.TabIndex = 30;
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullname.Location = new System.Drawing.Point(260, 79);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(70, 16);
            this.labelFullname.TabIndex = 44;
            this.labelFullname.Text = "notification";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 31);
            this.label6.TabIndex = 37;
            this.label6.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 38;
            this.label2.Text = "Full name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 37;
            this.label1.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 31);
            this.label4.TabIndex = 35;
            this.label4.Text = "Phone number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 31);
            this.label5.TabIndex = 34;
            this.label5.Text = "Address";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(579, 728);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(165, 62);
            this.btn_Update.TabIndex = 52;
            this.btn_Update.Text = "Update";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reset.Image")));
            this.btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reset.Location = new System.Drawing.Point(822, 728);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(153, 62);
            this.btn_Reset.TabIndex = 53;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // UC_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureEmployee);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Reset);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UC_Profile";
            this.Size = new System.Drawing.Size(1136, 860);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmployee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowHide)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CardPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo_suspended;
        private System.Windows.Forms.RadioButton rdo_locked;
        private System.Windows.Forms.RadioButton rdo_active;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox pictureEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ShowHide;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdo_Other;
        private System.Windows.Forms.RadioButton rdo_Male;
        private System.Windows.Forms.RadioButton rdo_Female;
        private System.Windows.Forms.ComboBox cbo_Position;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.PictureBox CardPhoto;
        private System.Windows.Forms.Button btn_ChooseImg;
        private System.Windows.Forms.TextBox txt_Fullname;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label labelPhonenumber;
        private System.Windows.Forms.TextBox txt_Phonenumber;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox txt_Salary;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Reset;
    }
}
