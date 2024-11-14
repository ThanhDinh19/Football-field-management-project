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
    public partial class UC_GiaoDienKH : UserControl
    {
        BLL_BookingSchedule BLL_BookingSchedule = new BLL_BookingSchedule();
        public UC_GiaoDienKH()
        {
            InitializeComponent();
        }

        private void UC_GiaoDienKH_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_BookingSchedule.getAllBookingSchedule();
        }
    }
}
