using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    // Class để tạo hàm trả về các hàm tương tác với bảng DichVu
    public class BLL_Services
    {
        DAL_Services DAL_Services = new DAL_Services();
        public DataTable getAllServices()
        {
            return DAL_Services.getAllServices();
        }
    }
}
