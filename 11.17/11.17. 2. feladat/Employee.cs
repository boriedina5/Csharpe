using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._17._2._feladat
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public Employee(string n, string p, decimal s) { 
            Name = n;
            Position = p;
            Salary = s;
        }
        public override string ToString() { 
            return $"{Name} - {Position}, {Salary}";
        }
    }
}
