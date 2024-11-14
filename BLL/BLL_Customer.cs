using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    // Class để tạo hàm trả về các hàm tương tác với bảng KhachHang
    public class BLL_Customer
    {
        DAL_Customer DAL_Customer = new DAL_Customer();
        public List<DTO_Customer> getAllCustomers()
        {
            return DAL_Customer.getAllCustomers();
        }
    }
}
