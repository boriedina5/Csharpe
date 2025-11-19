using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._feladat
{
    public class Tanulo
    {
        public string Nev { get; set; }
        public string TantargyNeve { get; set; }
        public List<int> Jegyek { get; set; }
        public Tanulo(string n, string tn, List<int> j) {
            Nev = n;
            TantargyNeve = tn;
            Jegyek = j;
        }
        public override string ToString() { 
            return $"{Nev} - {TantargyNeve}, {string.Join(" ",Jegyek)}";
        }
    }
}
