using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop_Surajmadaan.BussinessLayer
{
    public class Price
    {
        public int ID { get; set; }
        public decimal Rate { get; set; }
        public List<Customer> Customers { get; set; }

    }
}
