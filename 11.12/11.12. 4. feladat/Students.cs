using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._12._4._feladat
{
    public class Students
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }

        public Students(string n, int a, List<int> g) { 
            Name = n;
            Age = a;
            Grades = g;
        }
        public double Avarage() {
            int sum = 0;
            for (int i = 0; i < Grades.Count; i++) {
                sum += Grades[i];
            }
            return (double)sum/Grades.Count;
        }
        public int minGrade() {
            int min = Grades[0];
            for (int i = 1; i < Grades.Count; i++)
            {
                if (min > Grades[i]) { 
                    min = Grades[i];
                }
            }
            return min;
        }
        public int maxGrade()
        {
            int max = Grades[0];
            for (int i = 1; i < Grades.Count; i++)
            {
                if (max < Grades[i])
                {
                    max = Grades[i];
                }
            }
            return max;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
