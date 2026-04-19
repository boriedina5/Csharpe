using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._13._1._feladat
{
    public class Student
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public List<int> Grades { get; set; }

        public Student(string name, int age) {
            Name = name;
            Age = age;
            Grades = new List<int>();
        }

        public override string ToString()
        {
            return $"{Name} - {Age} éves, jegyei: {string.Join(" ", Grades)}";//paraméternek be lehet neki adni listákat
        }
    }
}
