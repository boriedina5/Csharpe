using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._feladat
{
    public class Tetel
    {
        public string TetelNeve { get; set; }
        public int TetelMennyiseg { get; set; }
        public int TetelEgysegara { get; set; }
        public Tetel(string tn, int tm, int te) { 
            TetelNeve = tn;
            TetelMennyiseg = tm;
            TetelEgysegara = te;
        }

        public override string ToString() { 
            return $"{TetelNeve} - {TetelMennyiseg}, {TetelEgysegara}";
        }
    }
}
