namespace QLSanBong.UC_Administrator
{
    partial class UC_AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddUser));
            this.labelNoti = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Salary = new System.Windows.Forms.TextBox();
            this.txt_Phonenumber = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Fullname = new System.Windows.Forms.TextBox();
            this.labelFullname = new System.Windows.Forms.Label();
            this.labelPhonenumber = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdo_Active = new System.Windows.Forms.RadioButton();
            this.rdo_Locked = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdo_Other = new System.Windows.Forms.RadioButton();
            this.rdo_Male = new System.Windows.Forms.RadioButton();
            this.rdo_Female = new System.Windows.Forms.RadioButton();
            this.cbo_Position = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.CardPhoto = new System.Windows.Forms.PictureBox();
            this.btn_ChooseImg = new System.Windows.Forms.Button();
            this.labelPosition = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ShowHide = new System.Windows.Forms.PictureBox();
            this.pic_valid = new System.Windows.Forms.PictureBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardPhoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_valid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNoti
            // 
            this.labelNoti.AutoSize = true;
            this.labelNoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoti.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelNoti.Location = new System.Drawing.Point(85, 795);
            this.labelNoti.Name = "labelNoti";
            this.labelNoti.Size = new System.Drawing.Size(96, 22);
            this.labelNoti.TabIndex = 43;
            this.labelNoti.Text = "notification";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 31);
            this.label5.TabIndex = 34;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 31);
            this.label4.TabIndex = 35;
            this.label4.Text = "Phone number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 37;
            this.label1.Text = "Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 38;
            this.label2.Text = "Full name";
            // 
            // txt_Salary
            // 
            this.txt_Salary.Location = new System.Drawing.Point(263, 247);
            this.txt_Salary.Multiline = true;
            this.txt_Salary.Name = "txt_Salary";
            this.txt_Salary.Size = new System.Drawing.Size(346, 44);
            this.txt_Salary.TabIndex = 30;
            // 
            // txt_Phonenumber
            // 
            this.txt_Phonenumber.Location = new System.Drawing.Point(263, 95);
            this.txt_Phonenumber.Multiline = true;
            this.txt_Phonenumber.Name = "txt_Phonenumber";
            this.txt_Phonenumber.Size = new System.Drawing.Size(346, 44);
            this.txt_Phonenumber.TabIndex = 31;
            this.txt_Phonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Phonenumber_KeyPress);
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(263, 170);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(346, 44);
            this.txt_Address.TabIndex = 32;
            // 
            // txt_Fullname
            // 
            this.txt_Fullname.Location = new System.Drawing.Point(263, 21);
            this.txt_Fullname.Multiline = true;
            this.txt_Fullname.Name = "txt_Fullname";
            this.txt_Fullname.Size = new System.Drawing.Size(346, 44);
            this.txt_Fullname.TabIndex = 33;
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullname.Location = new System.Drawing.Point(260, 68);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(70, 16);
            this.labelFullname.TabIndex = 44;
            this.labelFullname.Text = "notification";
            // 
            // labelPhonenumber
            // 
            this.labelPhonenumber.AutoSize = true;
            this.labelPhonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhonenumber.Location = new System.Drawing.Point(260, 142);
            this.labelPhonenumber.Name = "labelPhonenumber";
            this.labelPhonenumber.Size = new System.Drawing.Size(70, 16);
            this.labelPhonenumber.TabIndex = 44;
            this.labelPhonenumber.Text = "notification";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(260, 217);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(70, 16);
            this.labelAddress.TabIndex = 44;
            this.labelAddress.Text = "notification";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(260, 293);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(70, 16);
            this.labelSalary.TabIndex = 44;
            this.labelSalary.Text = "notification";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.cbo_Position);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txt_Fullname);
            this.groupBox1.Controls.Add(this.labelPosition);
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
            this.groupBox1.Location = new System.Drawing.Point(462, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 565);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdo_Active);
            this.groupBox5.Controls.Add(this.rdo_Locked);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(22, 493);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(339, 58);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Satus";
            // 
            // rdo_Active
            // 
            this.rdo_Active.AutoSize = true;
            this.rdo_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Active.Location = new System.Drawing.Point(51, 21);
            this.rdo_Active.Name = "rdo_Active";
            this.rdo_Active.Size = new System.Drawing.Size(76, 24);
            this.rdo_Active.TabIndex = 47;
            this.rdo_Active.TabStop = true;
            this.rdo_Active.Text = "Active";
            this.rdo_Active.UseVisualStyleBackColor = true;
            // 
            // rdo_Locked
            // 
            this.rdo_Locked.AutoSize = true;
            this.rdo_Locked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Locked.Location = new System.Drawing.Point(214, 21);
            this.rdo_Locked.Name = "rdo_Locked";
            this.rdo_Locked.Size = new System.Drawing.Size(84, 24);
            this.rdo_Locked.TabIndex = 48;
            this.rdo_Locked.TabStop = true;
            this.rdo_Locked.Text = "Locked";
            this.rdo_Locked.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdo_Other);
            this.groupBox4.Controls.Add(this.rdo_Male);
            this.groupBox4.Controls.Add(this.rdo_Female);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(22, 401);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 58);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gender";
            // 
            // rdo_Other
            // 
            this.rdo_Other.AutoSize = true;
            this.rdo_Other.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_Other.Location = new System.Drawing.Point(226, 24);
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
            this.rdo_Male.Location = new System.Drawing.Point(34, 24);
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
            this.rdo_Female.Location = new System.Drawing.Point(124, 24);
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
            this.cbo_Position.Location = new System.Drawing.Point(263, 331);
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
            this.groupBox3.Location = new System.Drawing.Point(384, 401);
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
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(260, 368);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(70, 16);
            this.labelPosition.TabIndex = 44;
            this.labelPosition.Text = "notification";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 31);
            this.label6.TabIndex = 37;
            this.label6.Text = "Position";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ShowHide);
            this.groupBox2.Controls.Add(this.pic_valid);
            this.groupBox2.Controls.Add(this.txt_Username);
            this.groupBox2.Controls.Add(this.labelPassword);
            this.groupBox2.Controls.Add(this.txt_Password);
            this.groupBox2.Controls.Add(this.labelUsername);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(460, 593);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 162);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Account";
            // 
            // ShowHide
            // 
            this.ShowHide.Image = global::QLSanBong.Properties.Resources.hide_passw_40px1;
            this.ShowHide.Location = new System.Drawing.Point(581, 92);
            this.ShowHide.Name = "ShowHide";
            this.ShowHide.Size = new System.Drawing.Size(47, 44);
            this.ShowHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowHide.TabIndex = 52;
            this.ShowHide.TabStop = false;
            this.ShowHide.Click += new System.EventHandler(this.ShowHide_Click);
            // 
            // pic_valid
            // 
            this.pic_valid.Location = new System.Drawing.Point(583, 20);
            this.pic_valid.Name = "pic_valid";
            this.pic_valid.Size = new System.Drawing.Size(45, 42);
            this.pic_valid.TabIndex = 51;
            this.pic_valid.TabStop = false;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(226, 18);
            this.txt_Username.Multiline = true;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(351, 44);
            this.txt_Username.TabIndex = 46;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(223, 139);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 16);
            this.labelPassword.TabIndex = 49;
            this.labelPassword.Text = "notification";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(226, 92);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(351, 44);
            this.txt_Password.TabIndex = 45;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(223, 65);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(70, 16);
            this.labelUsername.TabIndex = 50;
            this.labelUsername.Text = "notification";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(44, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 31);
            this.label14.TabIndex = 48;
            this.label14.Text = "Username";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(44, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 31);
            this.label15.TabIndex = 47;
            this.label15.Text = "Password";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Image = global::QLSanBong.Properties.Resources.reset_40px1;
            this.btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reset.Location = new System.Drawing.Point(958, 776);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(148, 54);
            this.btn_Reset.TabIndex = 48;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btn_SignUp.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignUp.ForeColor = System.Drawing.Color.White;
            this.btn_SignUp.Image = global::QLSanBong.Properties.Resources.register_40px1;
            this.btn_SignUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SignUp.Location = new System.Drawing.Point(725, 776);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(174, 54);
            this.btn_SignUp.TabIndex = 47;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSanBong.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(89, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // UC_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelNoti);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UC_AddUser";
            this.Size = new System.Drawing.Size(1136, 860);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CardPhoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_valid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNoti;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Salary;
        private System.Windows.Forms.TextBox txt_Phonenumber;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Fullname;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.Label labelPhonenumber;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox CardPhoto;
        private System.Windows.Forms.RadioButton rdo_Other;
        private System.Windows.Forms.RadioButton rdo_Female;
        private System.Windows.Forms.RadioButton rdo_Male;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_ChooseImg;
        private System.Windows.Forms.ComboBox cbo_Position;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.RadioButton rdo_Locked;
        private System.Windows.Forms.RadioButton rdo_Active;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pic_valid;
        private System.Windows.Forms.PictureBox ShowHide;
    }
}
