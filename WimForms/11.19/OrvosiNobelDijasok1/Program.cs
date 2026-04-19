namespace OrvosiNobelDijasok1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sorok = File.ReadAllLines("orvosi_nobeldijak.txt");
            List<Orvos> orvosok = new List<Orvos>();

            foreach (string s in sorok.Skip(1)) {//első sor átugrása 
                orvosok.Add(new Orvos(s));
            }
            //3. feladat
            Console.WriteLine($"+. feladat: Díjazottak száma: {orvosok.Count} fő");
            //4. feladat
            int utcsoEv = orvosok[0].Ev;
            foreach (var orvos in orvosok) {
                if (orvos.Ev > utcsoEv)
                {
                    utcsoEv = orvos.Ev;
                }
            }
            Console.WriteLine($"4. feladat: Utolsó év: {utcsoEv}");
            //5. feladat
            Console.WriteLine("5. feladat: Adja meg a ország kódját");
            string orszagkod = Console.ReadLine().ToUpper();
            List<Orvos> orszagbeliorvos = new List<Orvos>();
            foreach (var orvos in orvosok) { 
                if(orvos.Orszagkod == orszagkod)
                {
                    orszagbeliorvos.Add(orvos);
                }
            }
            if (orszagbeliorvos.Count == 0)
            {
                Console.WriteLine($"A megadott országból nem volt diíjazott!");
            }
            else if (orszagbeliorvos.Count == 1)
            {
                Console.WriteLine("A megadott ország díjazottja: ");
                Console.WriteLine($"Név: {orszagbeliorvos[0].Nev}");
                Console.WriteLine($"Év: {orszagbeliorvos[0].Ev}");
                Console.WriteLine($"Sz/H: {orszagbeliorvos[0].SzuletesHalalozas}");
            }
            else {
                Console.WriteLine($"Megadott országból {orszagbeliorvos.Count} díjazott");
            }

            //6.
            Console.WriteLine("6. feladat");
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var orvos in orvosok) {
                if (dict.ContainsKey(orvos.Orszagkod))
                {
                    dict[orvos.Orszagkod]++;
                }
                else {
                    dict.Add(orvos.Orszagkod, 1);
                }
            }
            foreach (var orvos in dict) {
                Console.WriteLine($"{orvos.Key} - {orvos.Value}.");
            }

        }
    }
}
