using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._19
{
    public class Feladat
    {
        public string Cim { get; set; }
        public DateTime Hatarido { get; set; }

        public int Prioritas { get; set; }

        public Feladat(string c, DateTime h, int p) { 
            Cim = c;
            Hatarido = h;
            Prioritas = p;
        }
        public override string ToString()
        {
            return $"{Cim} - {Hatarido}, {Prioritas}";
        }
    }
}
