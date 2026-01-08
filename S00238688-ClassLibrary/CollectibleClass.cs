using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S00238688_ClassLibrary
{
    internal class CollectibleClass
    {
        public int Collectible_ID { get; set; }
        public string Name { get; set; }
        public int Category_ID { get; set; }
        public decimal Price { get; set; }
        public string Condition { get; set; }
        public int Stock_Quantity { get; set; }
    }
}
