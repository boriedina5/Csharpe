using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrvosiNobelDijasok1
{
    public class Orvos
    {
        public int Ev { get; set; }
        public string Nev { get; set; }
        public string SzuletesHalalozas { get; set; }
        public string Orszagkod { get; set; }

        //Txt-ből beolvasva mit darabolunk fel
        public Orvos(string sor) {
            string[] splitted = sor.Split(";");
            Ev = int.Parse(splitted[0]);
            Nev = splitted[1];
            SzuletesHalalozas = splitted[2];
            Orszagkod = splitted[3];
        }
    }
}
