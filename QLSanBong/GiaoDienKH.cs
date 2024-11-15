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
using QLSanBong.UC_Customer;


namespace QLSanBong
{
    public partial class GiaoDienKH : Form
    {
        public GiaoDienKH()
        {
            InitializeComponent();
            format_btn();
        }
        private void format_btn()
        {
            btn_Photos.FlatStyle = FlatStyle.Flat;
            btn_Photos.FlatAppearance.BorderSize = 0;

            btn_Datsan.FlatStyle = FlatStyle.Flat;
            btn_Datsan.FlatAppearance.BorderSize = 0;

            btn_DatDV.FlatStyle = FlatStyle.Flat;
            btn_DatDV.FlatAppearance.BorderSize = 0;

            btn_Profile.FlatStyle = FlatStyle.Flat;
            btn_Profile.FlatAppearance.BorderSize = 0;

            btn_Logout.FlatStyle = FlatStyle.Flat;
            btn_Logout.FlatAppearance.BorderSize = 0;

        }
        void ResetBtn()
        {
            btn_Photos.BackColor = Color.FromArgb(128, 255, 128);
            btn_Photos.ForeColor = Color.DimGray;

            btn_Datsan.BackColor = Color.FromArgb(128, 255, 128);
            btn_Datsan.ForeColor = Color.DimGray;

            btn_DatDV.BackColor = Color.FromArgb(128, 255, 128);
            btn_DatDV.ForeColor = Color.DimGray;

            btn_Profile.BackColor = Color.FromArgb(128, 255, 128);
            btn_Profile.ForeColor = Color.DimGray;

            btn_Logout.BackColor = Color.FromArgb(128, 255, 128);
            btn_Logout.ForeColor = Color.DimGray;
        }
        private void GiaoDienKH_Load(object sender, EventArgs e)
        {
            btn_Photos.ForeColor = Color.Black;
            btn_Photos.BackColor = Color.White;
            uC_Images1.Visible = true;
            uC_Images1.BringToFront();
        }

        private void btn_Photos_Click(object sender, EventArgs e)
        {
            ResetBtn();
            btn_Photos.ForeColor = Color.Black;
            btn_Photos.BackColor = Color.White;

            uC_Images1.Visible = true;
            uC_Images1.BringToFront();
        }

        private void btn_Datsan_Click(object sender, EventArgs e)
        {
            ResetBtn();
            btn_Datsan.ForeColor = Color.Black;
            btn_Datsan.BackColor = Color.White;

            uC_DatSan1.Visible = true;
            uC_DatSan1.BringToFront();
        }

        private void btn_DatDV_Click(object sender, EventArgs e)
        {
            ResetBtn();
            btn_DatDV.ForeColor = Color.Black;
            btn_DatDV.BackColor = Color.White;

            uC_DatDichVu1.Visible = true;
            uC_DatDichVu1.BringToFront();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            ResetBtn();
            btn_Logout.ForeColor = Color.Black;
            btn_Logout.BackColor = Color.White;

            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {          
                SignInFormForCustomer newForm = new SignInFormForCustomer();
                newForm.Show();
                this.Hide();
                 
            }
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            ResetBtn();
            btn_Profile.ForeColor = Color.Black;
            btn_Profile.BackColor = Color.White;

            uC_ProfileKH1.Visible = true;
            uC_ProfileKH1.BringToFront();
        }
    }
}
