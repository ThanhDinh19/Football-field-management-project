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

namespace QLSanBong
{
    public partial class KhoHang : Form
    {
        BLL_Services BLL_Services = new BLL_Services();
        public KhoHang()
        {
            InitializeComponent();
        }

        private void KhoHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_Services.getAllServices();
        }
    }
}
