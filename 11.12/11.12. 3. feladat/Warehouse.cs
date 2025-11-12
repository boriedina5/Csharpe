using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._12._3._feladat
{
    public class Warehouse
    {
        public string CityName { get; set; }
        public List<Product> Products { get; set; }
        public Warehouse(string cn) { 
            CityName = cn;
            Products = new List<Product>();
        }
        public override string ToString() { 
            return CityName;
        }
    }
}
