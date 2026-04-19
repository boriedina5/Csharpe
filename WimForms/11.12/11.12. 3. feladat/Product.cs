using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._12._3._feladat
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int  Quantity { get; set; }

        public Product(string n, double p, int q) { 
            Name = n; 
            Price = p; 
            Quantity = q;
        }
        public override string ToString() {
            return $"{Name} - {Price} Ft, {Quantity}";
        }
    }
}
