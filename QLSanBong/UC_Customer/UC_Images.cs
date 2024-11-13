using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSanBong.UC_Customer
{
    public partial class UC_Images : UserControl
    {
        private List<Image> images = new List<Image>(); // Danh sách ảnh
        private int currentIndex = 0; // Chỉ mục của ảnh hi ện tại
        public UC_Images()
        {
            InitializeComponent();

            // Thêm ảnh vào danh sách (nếu ảnh ở Resources)
            images.Add(Properties.Resources.San1); // Thay "Image1" bằng tên ảnh trong Resources
            images.Add(Properties.Resources.San2);
            images.Add(Properties.Resources.San3);
            images.Add(Properties.Resources.San4);
            images.Add(Properties.Resources.San6);

            // Hiển thị ảnh đầu tiên
            Img_SanBong.Image = images[currentIndex];
        }

        private void UC_Images_Load(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click_1(object sender, EventArgs e)
        {
            // Chuyển đến ảnh tiếp theo
            currentIndex++;
            if (currentIndex >= images.Count)
            {
                currentIndex = 0; // Quay lại ảnh đầu tiên nếu đạt đến cuối
            }
            Img_SanBong.Image = images[currentIndex];
        }

        private void btn_Previous_Click_1(object sender, EventArgs e)
        {
            // Chuyển đến ảnh trước đó
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = images.Count - 1; // Quay lại ảnh cuối nếu vượt quá đầu danh sách
            }
            Img_SanBong.Image = images[currentIndex];
        }

        private void btn_Next_MouseEnter(object sender, EventArgs e)
        {
          
        }
        private void btn_Next_MouseHover(object sender, EventArgs e)
        {
            btn_Next.BackColor = Color.LightGray; // Thay đổi màu nền
            btn_Next.ForeColor = Color.DarkBlue;   // Thay đổi màu chữ (nếu muốn)
        }
        private void btn_Next_MouseLeave(object sender, EventArgs e)
        {
            btn_Next.BackColor = Color.White; // Đặt lại màu nền ban đầu        
        }
        private void btn_Previous_MouseHover(object sender, EventArgs e)
        {
            btn_Previous.BackColor = Color.LightGray; // Thay đổi màu nền
            btn_Previous.ForeColor = Color.DarkBlue;   // Thay đổi màu chữ (nếu muốn)
        }

        private void btn_Previous_MouseLeave(object sender, EventArgs e)
        {
            btn_Previous.BackColor = Color.White; // Đặt lại màu nền ban đầu       
        }
    }
}