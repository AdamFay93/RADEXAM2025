using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00238688_ClassLibrary
{
    public class OrderClass
    {
        public int Order_ID { get; set; }
        public int User_ID { get; set; }
        public decimal Total_Price { get; set; }
        public string Payment_Status { get; set; }
        public string Order_Status { get; set; }
    }
}
