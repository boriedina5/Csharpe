using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._12._1._feladat
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Car(string brand, string model, int year, double price) { 
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
        }

        public int Age() { 
            return DateTime.Now.Year - Year;
        }
        public override string ToString()
        {
            return $"{Brand} - {Model}, {Year}, {Price} Ft";
        }
    }
}
