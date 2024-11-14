using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    // Class của bảng KhachHang
    public class DTO_Customer
    {
        public string customerID {  get; set; }
        public string customerName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string identificationCode {  get; set; }

        public DTO_Customer() { }

        public DTO_Customer(string customerID, string customerName, string phoneNumber, string email, string identificationCode)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.identificationCode = identificationCode;
        }
    }
}
