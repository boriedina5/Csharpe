namespace KonyvekVizsgaGyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //beolv
            var lines = File.ReadAllLines("kolcsonzesek.txt").Skip(1);
            //[sor1, sor2, sor3...]
            List<Konyvek> konyvek = new List<Konyvek>();
            foreach (string line in lines) {
                konyvek.Add(new Konyvek(line)); //osztály elintézi maganák a többit
            }
            //3. feladat
            Console.WriteLine($"3. feladat: {konyvek.Count} könyv");

            //4. feladat
            int sum = 0;
            for (int j = 0; j < konyvek.Count; j++) { 
                sum += konyvek[j].Days;
            }
            double avg = (double)sum / konyvek.Count;
            Console.WriteLine($"4. feladat: {avg:F1}");

            //5. feladat
            Konyvek max = konyvek.First();
            for (int j = 0; j < konyvek.Count; j++) {
                if (konyvek[j].Days > max.Days) {
                    max = konyvek[j];
                }
            }
            Console.WriteLine($"5. feladat: {max.Name} - {max.Book} ({max.Days} nap)");

            //6. feladat
            int longerThan14DaysCount = 0;
            for (int j = 0; j < konyvek.Count; j++) {
                if (konyvek[j].Days > 14) {
                    longerThan14DaysCount++;
                }
            }
            Console.WriteLine($"6. feladat: {longerThan14DaysCount} kölcsönzés 14 napnál hosszabb");

            //7. feladat
            int i = 0;
            while (i < konyvek.Count && !(konyvek[i].Days < 5)) {
                i++;
            }
            if (i < konyvek.Count) {
                Console.WriteLine("7. feladat: Van rövid kölcsönzés");
            } else {
                Console.WriteLine("7. feladat: Nincs 5 napnál rövidebb kölcsönzés");
            }

            //8. feladat
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (Konyvek k in konyvek) {
                if (stat.ContainsKey(k.Book))
                {
                    stat[k.Book]++;
                }
                else {
                    stat.Add(k.Book, 1);
                }
                
            }
            Console.WriteLine("8.feladat: ");
            foreach (var item in stat) {
                Console.WriteLine($" {item.Key} - {item.Value} kölcsönzés");
            }

            //9. feladat
            List<string> output = new List<string>();
            for (int j = 0; j < konyvek.Count; j++) {
                if (konyvek[j].Days >= 14) { 
                    output.Add($"{konyvek[j].Name};{konyvek[j].Book};{konyvek[j].Days}");
                }
            }
            File.WriteAllLines("hosszu.txt", output);
        }
    }
}
