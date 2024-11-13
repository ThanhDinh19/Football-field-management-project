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
    public partial class UC_Profile : UserControl
    {
        DataProvider dataProvider = new DataProvider();
        string EmployeeID;
        string ImgName;
        string pathImage;
        public UC_Profile()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            load_cbo_Position();
        }

        private void load_cbo_Position()
        {
            DataTable dt = new DataTable();
            dt = dataProvider.ExecQuery("Select * from ChucVu");
            cbo_Position.DisplayMember = "TenCV";
            cbo_Position.ValueMember = "MaCV";
            cbo_Position.DataSource = dt;

            cbo_Position.SelectedIndex = 1;

            cbo_Position.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void ReceiveMessage(string employeeID = "")
        {
            EmployeeID = employeeID;
            cbo_Position.SelectedValue = dataProvider.ExecScalar("select MaCV from NhanVien where MaNhanVien = '" + employeeID + "'");
            txt_Fullname.Text = dataProvider.ExecScalar("select TenNhanVien from NhanVien where MaNhanVien = '" + employeeID + "'").ToString();
            txt_Phonenumber.Text = dataProvider.ExecScalar("select SoDienThoai from NhanVien where MaNhanVien = '" + employeeID + "'").ToString();
            txt_Address.Text = dataProvider.ExecScalar("select DiaChi from NhanVien where MaNhanVien = '" + employeeID + "'").ToString();
            txt_Salary.Text = dataProvider.ExecScalar("select Luong from NhanVien where MaNhanVien = '" + employeeID + "'").ToString();
            txt_Password.Text = dataProvider.ExecScalar("select PasswordNV from Table_UserNV where MaNhanVien = '" + employeeID + "'").ToString();

            string gender = dataProvider.ExecScalar("select GioiTinh from NhanVien where MaNhanVien = '" + employeeID + "'").ToString();
            if (gender.Trim() == "Male")
            {
                rdo_Male.Checked = true;
            }
            else if (gender.Trim() == "Other")
            {
                rdo_Other.Checked = true;
            }
            else
            {
                rdo_Female.Checked = true;
            }

            labelUsername.Text = dataProvider.ExecScalar("select TaiKhoanNV from Table_UserNV where MaNhanVien = '" + employeeID + "'").ToString(); ;

            string status = dataProvider.ExecScalar("select TrangThai from Table_UserNV where MaNhanVien = '" + employeeID + "'").ToString();
            if (status == "Active")
            {
                rdo_active.Checked = true;
            }
            else if (status == "Locked")
            {
                rdo_locked.Checked = true;
            }
            else
            {
                rdo_suspended.Checked = true;
            }

            string query_Img = "SELECT AnhThe FROM NhanVien WHERE MaNhanVien = '" + employeeID + "'";
            ImgName = dataProvider.ExecScalar(query_Img).ToString();
            DisplayEmployeeImage(ImgName);
        }

        private void DisplayEmployeeImage(string ImageName)
        {
            if (!string.IsNullOrEmpty(ImageName))
            {
                string pathImg = Path.Combine(Application.StartupPath, "AnhTheNhanVien", ImageName);
                pictureEmployee.Image = Image.FromFile(pathImg);
            }
            else
            {
                pictureEmployee.Image = Properties.Resources.noUserImage;
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            notification_txtEmpty();
            TextBox[] textBoxes = { txt_Fullname, txt_Phonenumber, txt_Address, txt_Salary, txt_Password };

            foreach (TextBox tb in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Focus();
                    return;
                }
            }

            update_employee();
            update_EmployeeImage();
            CardPhoto.Image = null;
        }

        private void update_EmployeeImage()
        {
            if (CardPhoto.Image != null)
            {
                string ImgName = dataProvider.ExecScalar("select AnhThe from NhanVien where MaNhanVien = '" + EmployeeID + "'").ToString();
                if (string.IsNullOrEmpty(ImgName))
                {
                    saveImg(pathImage, EmployeeID);
                }
                else
                {
                    saveImg(pathImage, EmployeeID);
                }
            }
        }

        private void saveImg(string fileImage, string empID)
        {
            string pathImg = string.IsNullOrEmpty(fileImage) ? null : fileImage;

            string Img;

            if (!string.IsNullOrEmpty(pathImg))
            {
                SaveImageToContainFolder(pathImg, empID);
                string extension = Path.GetExtension(pathImg);
                Img = Path.GetFileName(empID + extension);
            }
            else
            {
                Img = "";
            }
            string query = "update NhanVien set AnhThe = '" + Img + "' where MaNhanVien = '" + EmployeeID + "'";
            dataProvider.ExecNonQuery(query);
        }

        private void SaveImageToContainFolder(string imagePath, string primaryKey)
        {
            if (!File.Exists(imagePath))
            {
                MessageBox.Show("The source image file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string exstension = Path.GetExtension(imagePath);
            string fileName = primaryKey + exstension;

            string destinationDirectory = Path.Combine(Application.StartupPath, "AnhTheNhanVien");
            string destinationPath = Path.Combine(destinationDirectory, fileName);

            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }

            try
            {
                File.Copy(imagePath, destinationPath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error copying the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void notification_txtEmpty()
        {
            TextBox[] textBoxes = { txt_Fullname, txt_Phonenumber, txt_Address, txt_Salary, txt_Password };
            foreach (TextBox tb in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    if (tb.Name == "txt_Fullname")
                    {
                        labelFullname.Text = "Please enter fullname";
                        labelFullname.ForeColor = Color.Red;
                        labelFullname.Visible = true;
                    }
                    if (tb.Name == "txt_Phonenumber")
                    {
                        labelPhonenumber.Text = "Please enter phone number";
                        labelPhonenumber.ForeColor = Color.Red;
                        labelPhonenumber.Visible = true;
                    }
                    if (tb.Name == "txt_Address")
                    {
                        labelAddress.Text = "Please enter address";
                        labelAddress.ForeColor = Color.Red;
                        labelAddress.Visible = true;
                    }
                    if (tb.Name == "txt_Salary")
                    {
                        labelSalary.Text = "Please enter salary";
                        labelSalary.ForeColor = Color.Red;
                        labelSalary.Visible = true;
                    }

                    if (tb.Name == "txt_Password")
                    {
                        labelPassword.Text = "Please enter password";
                        labelPassword.ForeColor = Color.Red;
                        labelPassword.Visible = true;
                    }
                }
                else
                {
                    if (tb.Name == "txt_Fullname")
                    {
                        labelFullname.Visible = false;
                    }
                    if (tb.Name == "txt_Phonenumber")
                    {
                        labelPhonenumber.Visible = false;
                    }
                    if (tb.Name == "txt_Address")
                    {
                        labelAddress.Visible = false;
                    }
                    if (tb.Name == "txt_Salary")
                    {
                        labelSalary.Visible = false;
                    }
                    if (tb.Name == "txt_Password")
                    {
                        labelPassword.Visible = false;
                    }
                }
            }
        }

        private void update_employee()
        {
            try
            {
                StringBuilder query_1 = new StringBuilder("EXEC proc_UpdateEmployee ");
                query_1.Append(" @MaNhanVien, @MaCV, @TenNhanVien, @SoDienThoai, @DiaChi, @GioiTinh, @Luong");

                string gender = getGender();

                Dictionary<string, object> parameters_1 = new Dictionary<string, object>()
                {
                    {"@MaNhanVien", EmployeeID},
                    {"@MaCV", cbo_Position.SelectedValue},
                    {"@TenNhanVien", txt_Fullname.Text},
                    {"@SoDienThoai", txt_Phonenumber.Text },
                    {"@DiaChi", txt_Address.Text },
                    {"@GioiTinh", gender},
                    {"@Luong", txt_Salary.Text}
                };
                int result_1 = dataProvider.ExecNonQuery(query_1.ToString(), parameters_1);


                string status = getStatus();

                StringBuilder query_2 = new StringBuilder("EXEC proc_UpdateUserNV ");
                query_2.Append(" @MaNhanVien, @PasswordNV, @TrangThai");

                Dictionary<string, object> parameters_2 = new Dictionary<string, object>()
                {
                    {"@MaNhanVien", EmployeeID},
                    {"@PasswordNV", txt_Password.Text},
                    {"@TrangThai", status}
                };
                int result_2 = dataProvider.ExecNonQuery(query_2.ToString(), parameters_2);

                if (result_1 > 0 && result_2 > 0)
                {
                    MessageBox.Show("Update succeeded !", "Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Update failed. Please try again.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private string getStatus()
        {
            string status = "";
            if (rdo_active.Checked)
            {
                status = rdo_active.Text;
            }
            else if (rdo_locked.Checked)
            {
                status = rdo_locked.Text;
            }
            else
            {
                status = rdo_suspended.Text;
            }
            return status;
        }

        private string getGender()
        {
            string gender = "";
            if (rdo_Male.Checked)
            {
                gender = rdo_Male.Text;
            }
            else if (rdo_Female.Checked)
            {
                gender = rdo_Female.Text;
            }
            else
            {
                gender = rdo_Other.Text;
            }
            return gender;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ReceiveMessage(EmployeeID);
            CardPhoto.Image = null;
        }

        private void btn_ChooseImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathImage = openFileDialog.FileName;

                    if (string.IsNullOrEmpty(pathImage))
                    {
                        return;
                    }
                    Image NewImg = Image.FromFile(pathImage);
                    CardPhoto.Image = NewImg;
                    pictureEmployee.Image = NewImg;
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            CardPhoto.Image = null;
        }
    }
}
