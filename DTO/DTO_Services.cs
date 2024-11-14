using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Services
    {
        public string serviceID {  get; set; }
        public string serviceName { get; set; }
        public decimal price { get; set; }

        public DTO_Services() { }
        public DTO_Services(string serviceID, string serviceName, decimal price)
        {
            this.serviceID = serviceID;
            this.serviceName = serviceName;
            this.price = price;
        }
    }
}
