using System;
using System.Collections.Generic;
using System.Text;

namespace Beolv
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public Person(string row)
        {
            string[] s = row.Split(',');
            Name = s[0];
            Age = int.Parse(s[1]);
            City = s[2];
        }

    }
}
