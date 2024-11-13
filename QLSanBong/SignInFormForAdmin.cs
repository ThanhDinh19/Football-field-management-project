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
        DataProvider dataProvider = new DataProvider();

        public SignInFormForAdmin()
        {
            InitializeComponent();
            init();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Password.Clear();
            txt_Username.Clear(); 
            labelNotification.Text = string.Empty;
            labelPassword.Text = string.Empty;
            labelPUsername.Text = string.Empty;
            cbo_Role.SelectedIndex = 0;
        }

        private void init()
        {
            load_cbo_role();
            invisible();
        }
        private void load_cbo_role()
        {
            DataTable dt = new DataTable();
            dt = dataProvider.ExecQuery("Select * from ChucVu");
            cbo_Role.DisplayMember = "TenCV";
            cbo_Role.ValueMember = "MaCV";
            cbo_Role.DataSource = dt;

            cbo_Role.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void invisible()
        {
            labelNotification.Text = string.Empty;
            labelPassword.Text = string.Empty;
            labelPUsername.Text = string.Empty;
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            notification_txtEmpty();
            TextBox[] textBoxes = { txt_Username, txt_Password };
            foreach (TextBox tb in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Focus();
                    return;
                }
            }

            SignIn();
        }

        private void SignIn()
        {
            int role = int.Parse(cbo_Role.SelectedValue.ToString());

            if (role == 1)
            {
                StringBuilder query = new StringBuilder(" select count(*) from NhanVien nv, Table_UserNV us where nv.MaNhanVien = us.MaNhanVien and us.TaiKhoanNV = '"+txt_Username.Text+"' and us.PasswordNV = '"+txt_Password.Text+"' and nv.MaCV = 1");               
                int result = int.Parse(dataProvider.ExecScalar(query.ToString()).ToString());
                if (result > 0)
                {
                    StringBuilder query_Status = new StringBuilder(" select TrangThai from Table_UserNV where TaiKhoanNV = '" + txt_Username.Text + "'");
                    string Status = dataProvider.ExecScalar(query_Status.ToString()).ToString();

                    if (Status == "Active")
                    {
                        StringBuilder query_EmpID = new StringBuilder(" select nv.MaNhanVien from NhanVien nv, Table_UserNV us where nv.MaNhanVien = us.MaNhanVien and us.TaiKhoanNV = '"+txt_Username.Text+"'");
                        string empID = dataProvider.ExecScalar(query_EmpID.ToString()).ToString();

                        Administrator am = new Administrator(empID);
                        am.Show();
                        this.Hide();
                    }
                    else if (Status == "Locked")
                    {
                        labelNotification.Text = "Account has been locked !";
                        return;
                    }
                    else
                    {
                        labelNotification.Text = "Account is suspended !";
                        return;
                    }
                }
                else
                {
                    labelNotification.Text = "Login failed: username or password is wrong !";
                }
            }
            else
            {
                /* awaiting processing */

                //StringBuilder query = new StringBuilder();
                //query.Append(" select count(*) ");
                //query.Append(" from Employee emp, tbl_User us ");
                //query.Append(" where emp.EmployeeID = us.EmployeeID and us.UserName = '" + txt_UserName.Text + "' and us.Password = '" + txt_Password.Text + "' and us.UserRole = 2 ");
                //int result = int.Parse(dataProvider.ExecScaler(query.ToString()).ToString());
                //if (result > 0)
                //{
                //    StringBuilder query_Status = new StringBuilder(" select Status from tbl_User where UserName = '" + txt_UserName.Text + "'");
                //    string Status = dataProvider.ExecScaler(query_Status.ToString()).ToString();

                //    if (Status == "Active")
                //    {
                //        StringBuilder query_EmpID = new StringBuilder(" select EmployeeID from tbl_User where UserName = '" + txt_UserName.Text + "'");
                //        string empID = dataProvider.ExecScaler(query_EmpID.ToString()).ToString();

                //        Pharmacist pm = new Pharmacist(empID); // neu co phat sinh can username thi da co san
                //        pm.Show();
                //        this.Hide();
                //    }
                //    else if (Status == "Locked")
                //    {
                //        MessageBox.Show("Account has been locked !", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //        return;
                //    }
                //    else
                //    {
                //        MessageBox.Show("Account is suspended !", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //        return;
                //    }

                //}
                //else
                //{
                //    MessageBox.Show("Account or password is incorrect", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            }

        }

        private void notification_txtEmpty()
        {
            TextBox[] textBoxes = { txt_Username, txt_Password };
            foreach (TextBox tb in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    if (tb.Name == "txt_Username")
                    {
                        labelPUsername.Text = "Please enter username";
                        labelPUsername.Visible = true;
                    }
                    if (tb.Name == "txt_Password")
                    {
                        labelPassword.Text = "Please enter password";
                        labelPassword.Visible = true;
                    }             
                }
                else
                {
                    if (tb.Name == "txt_Username")
                    {
                        labelPUsername.Visible = false;
                    }
                    if (tb.Name == "txt_Password")
                    {
                        labelPassword.Visible = false;
                    }                  
                }
            }
        }

        private void ShowHide_Click(object sender, EventArgs e)
        {
            if (txt_Password.PasswordChar == '*')
            {
                txt_Password.PasswordChar = '\0';
                ShowHide.Image = Properties.Resources.show_passw_40px;
            }
            else
            {
                txt_Password.PasswordChar = '*';
                ShowHide.Image = Properties.Resources.hide_passw_40px;
            }
        }
    }
}
