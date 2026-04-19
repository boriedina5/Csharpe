using System;
using System.Collections.Generic;
using System.Text;

namespace KonyvekVizsgaGyak
{
    public class Konyvek
    {
        public string Name { get; set; }
        public string Book { get; set; }
        public int Days { get; set; }

        public Konyvek(string row) { 
               string[] rowData = row.Split(';');
               Name = rowData[0];
               Book = rowData[1];
               Days = int.Parse(rowData[2]);
        }
    }
}
