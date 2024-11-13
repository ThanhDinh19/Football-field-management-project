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

        }
        void ResetBtn()
        {
            btn_Photos.BackColor = Color.FromArgb(128, 255, 128);
            btn_Photos.ForeColor = Color.DimGray;

            btn_Datsan.BackColor = Color.FromArgb(128, 255, 128);
            btn_Datsan.ForeColor = Color.DimGray;

            btn_DatDV.BackColor = Color.FromArgb(128, 255, 128);
            btn_DatDV.ForeColor = Color.DimGray;
        }
        private void GiaoDienKH_Load(object sender, EventArgs e)
        {
            btn_Photos.ForeColor = Color.Black;
            btn_Photos.BackColor = Color.White;
        }

        private void btn_Photos_Click(object sender, EventArgs e)
        {
            ResetBtn();
            btn_Photos.ForeColor = Color.Black;
            btn_Photos.BackColor = Color.White;

            uC_Images1.Visible = true;
            uC_Images1.BringToFront();
        }

        private void uC_Images1_Load(object sender, EventArgs e)
        {

        }
    }
}
