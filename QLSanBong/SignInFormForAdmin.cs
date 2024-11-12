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
    public partial class SignInFormForAdmin : Form
    {
        public SignInFormForAdmin()
        {
            InitializeComponent();
            init();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {

        }

        private void init()
        {
            load_cbo_role();
        }
        private void load_cbo_role()
        {
            string[] roles = { "Administrator", "Staff"};
            cbo_Role.Items.AddRange(roles);

            cbo_Role.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
