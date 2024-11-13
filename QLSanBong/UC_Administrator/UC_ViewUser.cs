using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanBong.UC_Administrator
{
    public partial class UC_ViewUser : UserControl
    {
        public event EventHandler<MessageEventArgs> ShowUpdateUserControlWithMessage;

        DataProvider dataProvider = new DataProvider();

        public UC_ViewUser()
        {
            InitializeComponent();
            init();
        }


        private void init()
        {
            btn_Delete.Enabled = false;
            load_dgv_Employee();
        }

        private void load_dgv_Employee(string search = "")
        {
            if (search == "")
            {
                DataTable dt = new DataTable();
                string query = "EXEC proc_ViewUser";
                dt = dataProvider.ExecQuery(query);

                dgv_Employee.DataSource = dt;
            }
            else
            {
                StringBuilder query = new StringBuilder("proc_ViewUser_by_search ");
                query.Append(" @search");
                DataTable dt = new DataTable();
                Dictionary<string, object> parameters = new Dictionary<string, object>()
                {
                    {"@search", search}
                };
                dt = dataProvider.ExecQuery(query.ToString(), parameters);
                dgv_Employee.DataSource = dt;
            }          
        }

        private void dgv_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_Employee.Rows.Count - 1)
            {
                btn_Delete.Enabled = true;

                //display medic img
                int index = e.RowIndex;
                string EmpID = dgv_Employee.Rows[index].Cells[0].Value.ToString();
                string query_Img = "SELECT AnhThe FROM NhanVien WHERE MaNhanVien = '" + EmpID + "'";
                string ImgName = dataProvider.ExecScalar(query_Img).ToString();
                DisplayEmployeeImage(ImgName);
            }
            else
            {
                btn_Delete.Enabled = false;
                picture_Emp.Image = null;
            }
        }

        private void DisplayEmployeeImage(string ImageName)
        {
            if (!string.IsNullOrEmpty(ImageName))
            {
                string pathImg = Path.Combine(Application.StartupPath, "AnhTheNhanVien", ImageName);
                picture_Emp.Image = Image.FromFile(pathImg);
            }
            else
            {
                picture_Emp.Image = null;
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            load_dgv_Employee(txt_Search.Text);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            load_dgv_Employee();
            txt_Search.Clear();
            btn_Delete.Enabled = false;
            picture_Emp.Image = null;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void delete()
        {
            DialogResult r = MessageBox.Show("Are you sure ? ", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (dgv_Employee.SelectedRows.Count > 0)
                {
                    try
                    {
                        foreach (DataGridViewRow row in dgv_Employee.SelectedRows)
                        {
                            string EmpID = row.Cells[0].Value.ToString();
                            string query_del_acc = "DELETE Table_UserNV WHERE MaNhanVien = '" + EmpID + "'"; // delete account cua nhan vien truoc vi chua khoa ngoai
                            dataProvider.ExecNonQuery(query_del_acc);
                          
                            string query_del_emp = "DELETE NhanVien WHERE MaNhanVien = '" + EmpID + "'"; // tiep den delete nhan vien
                            dataProvider.ExecNonQuery(query_del_emp.ToString());                          
                        }
                        load_dgv_Employee();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Employee.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please choose one!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string EmpID = "";
                foreach (DataGridViewRow row in dgv_Employee.SelectedRows)
                {
                    if (row.Cells[0].Value != null) 
                    {
                        EmpID = row.Cells[0].Value.ToString().Trim();
                    }
                    else
                    {
                        MessageBox.Show("Selected row is invalid!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                //perform event
                ShowUpdateUserControlWithMessage?.Invoke(this, new MessageEventArgs(EmpID));
            }
            catch
            {
                MessageBox.Show("An error occurred. Please try again!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
