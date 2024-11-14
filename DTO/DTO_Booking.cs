using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // class của bảng DatSan
    public class DTO_Booking
    {   
        public string bookingID {  get; set; }
        public string fieldID { get; set; }
        public DateTime dateBooking {  get; set; }
        public TimeSpan startTime { get; set; }
        public TimeSpan endTime { get; set; }

        public float totalPrice { get; set; }
        public string status { get; set; }

        public DTO_Booking() { }
        public DTO_Booking(string bookingID, string fieldID, DateTime dateBooking, TimeSpan startTime, TimeSpan endTime, float totalPrice, string status)
        {
            this.bookingID = bookingID;
            this.fieldID = fieldID;
            this.dateBooking = dateBooking;
            this.startTime = startTime;
            this.endTime = endTime;
            this.totalPrice = totalPrice;
            this.status = status;
        }
    }
}
