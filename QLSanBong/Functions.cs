using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSanBong
{
    public class Functions
    {
        DataProvider dataProvider = new DataProvider();

        public string CreateEmpID()
        {
            string newID = "EMP000001"; // Mã phiếu nhập mặc định nếu chưa có trong cơ sở dữ liệu
            string sql = "SELECT TOP 1 MaNhanVien FROM NhanVien ORDER BY MaNhanVien DESC";

            DataTable dt = new DataTable();

            dt = dataProvider.ExecQuery(sql);

            if (dt.Rows.Count > 0)
            {
                string oldID = dt.Rows[0][0].ToString();
                int STT = int.Parse(oldID.Substring(3)) + 1;
                newID = "EMP" + STT.ToString("D6"); // Định dạng với 7 chữ số, thêm số 0 nếu cần
            }
            return newID;
        }
    }
}
