using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSanBong.UC_Administrator;

namespace QLSanBong
{
    public partial class Administrator : Form
    {
        DataProvider dataProvider = new DataProvider();
        string employeeID;
        public Administrator(string EmployeeID)
        {
            InitializeComponent();
            employeeID = EmployeeID;
            init();
            uC_ViewUser1.ShowUpdateUserControlWithMessage += UC_ViewUsers1_ShowUpdateUserControlWithMessage;
        }

        private void UC_ViewUsers1_ShowUpdateUserControlWithMessage(object sender, MessageEventArgs e)
        {
            uC_UpdateUser1.SetMessage(e.Message); // Truyền chuỗi qua UC_UpdateUser
            uC_UpdateUser1.Visible = true;
            uC_UpdateUser1.BringToFront(); // Hiển thị UC_UpdateUser
        }

        private void init()
        {
            labelUsername.Text = userName();       
            format_btn();
        }

        private string userName()
        {
            string query = "select us.TaiKhoanNV from NhanVien nv, Table_UserNV us where nv.MaNhanVien = us.MaNhanVien and nv.MaNhanVien = '"+employeeID+"'";
            string usname = dataProvider.ExecScalar(query).ToString();     
            return usname;
        }

        private void format_btn()
        {
            btn_Dashboard.FlatStyle = FlatStyle.Flat;
            btn_Dashboard.FlatAppearance.BorderSize = 0;

            btn_AddUser.FlatStyle = FlatStyle.Flat;
            btn_AddUser.FlatAppearance.BorderSize = 0;

            btn_ViewUser.FlatStyle = FlatStyle.Flat;
            btn_ViewUser.FlatAppearance.BorderSize = 0;

            btn_Profile.FlatStyle = FlatStyle.Flat;
            btn_Profile.FlatAppearance.BorderSize = 0;

            btn_LogOut.FlatStyle = FlatStyle.Flat;
            btn_LogOut.FlatAppearance.BorderSize = 0;          
        }

        void ResetBtn()
        {
            btn_Dashboard.BackColor = Color.FromArgb(128, 255, 128);
            btn_Dashboard.ForeColor = Color.DimGray;

            btn_AddUser.BackColor = Color.FromArgb(128, 255, 128);
            btn_AddUser.ForeColor = Color.DimGray;

            btn_ViewUser.BackColor = Color.FromArgb(128, 255, 128);
            btn_ViewUser.ForeColor = Color.DimGray;

            btn_Profile.BackColor = Color.FromArgb(128, 255, 128);
            btn_Profile.ForeColor = Color.DimGray;

            btn_LogOut.BackColor = Color.FromArgb(128, 255, 128);
            btn_LogOut.ForeColor = Color.DimGray;
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_AddUser1.Visible = false;
            uC_ViewUser1.Visible = false;
            uC_UpdateUser1.Visible = false;
            uC_Profile1.Visible = false;
            btn_Dashboard.PerformClick();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            ResetBtn();
            btn_Dashboard.ForeColor = Color.Black;
            btn_Dashboard.BackColor = Color.White;

            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            ResetBtn();
            btn_AddUser.ForeColor = Color.Black;
            btn_AddUser.BackColor = Color.White;

            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void btn_ViewUser_Click(object sender, EventArgs e)
        {
            ResetBtn();
            btn_ViewUser.ForeColor = Color.Black;
            btn_ViewUser.BackColor = Color.White;

            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            ResetBtn();
            btn_Profile.ForeColor = Color.Black;
            btn_Profile.BackColor = Color.White;

            uC_Profile1.Visible = true;
            uC_Profile1.ReceiveMessage(employeeID);
            uC_Profile1.BringToFront();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            ResetBtn();
            btn_LogOut.ForeColor = Color.Black;
            btn_LogOut.BackColor = Color.White;

            SignInFormForAdmin signinform = new SignInFormForAdmin();
            signinform.Show();
            this.Hide();
        }

      
    }
}
