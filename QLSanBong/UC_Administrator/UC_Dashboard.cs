using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanBong.UC_Administrator
{
    public partial class UC_Dashboard : UserControl
    {
        DataProvider dataProvider = new DataProvider();

        public UC_Dashboard()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            load();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            string countStaff = dataProvider.ExecScalar("select count(*) from NhanVien where MaCV = 2").ToString();
            string countAdmin = dataProvider.ExecScalar("select count(*) from NhanVien where MaCV = 1").ToString();

            labelStaff.Text = countStaff;
            labelAdmin.Text = countAdmin;
        }
    }
}
