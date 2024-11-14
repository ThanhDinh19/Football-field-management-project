using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //Class của bảng SanBong
    public class DTO_SoccerField
    {
        public string fieldID { get; set; }
        public string fieldName { get; set; }
        public decimal price { get; set; }
        public string status { get; set; }
        public string type { get; set; }

        public DTO_SoccerField() { }

        public DTO_SoccerField(string fieldID, string fieldName, decimal price, string status, string type)
        {
            this.fieldID = fieldID;
            this.fieldName = fieldName;
            this.price = price;
            this.status = status;
            this.type = type;
        }
    }
}
