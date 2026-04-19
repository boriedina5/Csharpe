using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._feladat
{
    public class Tantargyjegyzek
    {
        public string TantargyNeve { get; set; }
        public int HetiOraSzam { get; set; }
        public string TanarNeve { get; set; }

        public Tantargyjegyzek(string tn, int hosz, string tN) {
            TantargyNeve = tn;
            HetiOraSzam = hosz;
            TanarNeve = tN;
        }

        public override string ToString() {
            return $"{TantargyNeve} - {HetiOraSzam}, {TanarNeve}";
        }
    }
}
