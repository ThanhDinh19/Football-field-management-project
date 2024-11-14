using BLL;
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
    public partial class UC_KhoHang : UserControl
    {
        BLL_Services BLL_Services = new BLL_Services();
        public UC_KhoHang()
        {
            InitializeComponent();
        }

        private void UC_KhoHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_Services.getAllServices();
        }
    }
}
