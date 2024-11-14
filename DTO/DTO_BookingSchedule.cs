using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // Class của func_getTable_bookingSchedule
    public class DTO_BookingSchedule
    {
        public string fieldID { get; set; }
        public string fieldName { get; set; }
        public decimal price { get; set; }
        public DateTime dateBooking { get; set; }
        public TimeSpan startTime { get; set; }
        public TimeSpan endTime { get; set; }
        public string type { get; set; }
        public string status { get; set; }

        public DTO_BookingSchedule() { }

        public DTO_BookingSchedule(string fieldID, string fieldName, decimal price, DateTime dateBooking, TimeSpan startTime, TimeSpan endTime, string type, string status)
        {
            this.fieldID = fieldID;
            this.fieldName = fieldName;
            this.price = price;
            this.dateBooking = dateBooking;
            this.startTime = startTime;
            this.endTime = endTime;
            this.type = type;
            this.status = status;
        }
    }
}
