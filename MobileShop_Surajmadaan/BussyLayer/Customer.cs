using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop_Surajmadaan.BussinessLayer
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int ModelID { get; set; }
        public int PriceID { get; set; }
        public Model Model { get; set; }
        public Price Price { get; set; }
    }
}
