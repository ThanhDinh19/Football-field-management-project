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
        public Administrator()
        {
            InitializeComponent();
            format_btn();
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
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            ResetBtn();
            btn_Profile.ForeColor = Color.Black;
            btn_Profile.BackColor = Color.White;
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            ResetBtn();
            btn_LogOut.ForeColor = Color.Black;
            btn_LogOut.BackColor = Color.White;
        }

        private void uC_AddUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
