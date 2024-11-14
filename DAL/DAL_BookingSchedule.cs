using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    // Class để tạo hàm tương tác với func_getTable_bookingSchedule
    public class DAL_BookingSchedule : DataProvider
    {   
        public DataTable getAllBookingSchedule()
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == conn.State)
            {
                conn.Open();
            }
            string sql = "exec proc_getAllBookingSchedule";
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
