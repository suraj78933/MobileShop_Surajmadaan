using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop_Surajmadaan.BussinessLayer
{
    public class Model
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
