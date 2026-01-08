using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00238688_ClassLibrary
{
    public class OrderItemClass
    {
        public int Order_Item_ID { get; set; }
        public int Order_ID { get; set; }
        public int Collectible_ID { get; set; }
        public int Quantity { get; set; }
        public decimal Unit_Price { get; set; }
    }
}
