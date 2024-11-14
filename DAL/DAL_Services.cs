using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    // Class để tạo hàm tương tác với bảng DichVu
    public class DAL_Services : DataProvider
    {
        // Lấy tất cả dữ liệu từ bảng DichVu và đưa vào datatable
        public DataTable getAllServices()
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
            string sql = "exec proc_getAllServices";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
