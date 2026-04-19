using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _11._11._1._feladat
{
    public class Cars
    {
        
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }

        public Cars(string brand, string model, int year, int price) { 
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
        }
        public int Age() {
            int age = DateTime.Now.Year - Year;
            return age;
        }
    }
}
