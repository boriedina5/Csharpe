using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._11._1._feladat
{
    public class Students
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
        public Students(string name, int age, List<int> grades) { 
            Name = name;
            Age = age;
            Grades = grades;
        }
        public virtual void AddGradesToList() {
            Console.Write("ENter the students grade: ");
            int newGrade = int.Parse(Console.ReadLine());
            Grades.Add(newGrade);
        }

        public decimal Avarage()
        {
            int sum = 0;
            for (int i = 0; i < Grades.Count; i++) { 
                sum += Grades[i];
            }
            return (decimal)sum/Grades.Count;
        }
        public int MinGrade()
        {
            int min = Grades[0];
            for (int i = 1; i < Grades.Count; i++) {
                if (min > Grades[i]) { 
                    min = Grades[i];
                }
            }
            return min;
        }
        public int MaxGrade()
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
    }   
}
