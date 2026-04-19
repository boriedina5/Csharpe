using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BevasarloLista
{
    public class ShoppingItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public ShoppingItem(string name, int quantity, double price ) { 
            Name = name;
            Quantity = quantity;
            Price = price;
        
        }
        public override string ToString()
        {
            return $"{Name} - {Quantity} - {Price}";
        }
    }
}
