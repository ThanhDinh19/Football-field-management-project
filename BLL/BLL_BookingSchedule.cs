using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    // Class để tạo hàm trả về các hàm tương tác với func_getTable_bookingSchedule
    public class BLL_BookingSchedule
    {
        DAL_BookingSchedule DAL_BookingSchedule = new DAL_BookingSchedule();

        public DataTable getAllBookingSchedule()
        {
            return DAL_BookingSchedule.getAllBookingSchedule();
        }
    }
}
