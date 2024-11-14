using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    // Class để tạo hàm tương tác với bảng KhachHang
    public class DAL_Customer : DataProvider
    {
        // Lấy tất cả khách hàng trong database và đưa vào list
        public List<DTO_Customer> getAllCustomers()
        {
            List<DTO_Customer> customer_lst = null;
            if(ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
            string sql = "EXEC proc_getAllCustomers";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    DTO_Customer customer = new DTO_Customer()
                    {
                        customerID = read[0].ToString(),
                        customerName = read[1].ToString(),
                        phoneNumber = read[2].ToString(),
                        email = read[3].ToString(),
                        identificationCode = read[4].ToString()
                    };
                    customer_lst.Add(customer);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return customer_lst;
        }
    }
}
