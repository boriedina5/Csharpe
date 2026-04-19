namespace Beolv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] rows = File.ReadAllLines("adatok.txt");
            //[sor1, sor2, sor3...]
            List<Person> people  = new List<Person>();
            foreach (string row in rows) { 
                people.Add(new Person(row));
            }

            Console.WriteLine($"3. feladat: {people.Count} található a fájlban");

            //4. felafdat
            //LINQ
            double avgAge = people.Average(p => p.Age);

            //Algoritmus
            avgAge = 0;
            for (int i = 0; i < people.Count; i++) { 
                avgAge += people[i].Age;
            }
            avgAge = avgAge / people.Count;

            Console.WriteLine($"4. feladat: Az emberek átlag életkora: {avgAge:F1}"); //Math.round helyett ez jobb, mert nem módosít, a szám a tizedes jegyek számát jelöli

            //5. felafdat
            //LINQ
            Person eldest = people.MaxBy(p => p.Age);
            Person youngest = people.MinBy(p => p.Age);

            //Alg
            eldest = people.First();
            youngest = people.First();
            for (int i = 0; i < people.Count; i++) {
                if (people[i].Age > eldest.Age) { 
                    eldest = people[i];
                }
                if (people[i].Age < youngest.Age) { 
                    youngest = people[i];
                }

            }
            Console.WriteLine("5. feladdat");
            Console.WriteLine($"\tLegidősebb ember: {eldest.Name}, {eldest.Age}, {eldest.City}");
            Console.WriteLine($"\tLegidősebb ember: {youngest.Name}, {youngest.Age}, {youngest.City}");

            // 6. feladat
            //LINQ
            int countKecskemet = people.Count(x => x.City == "Kecskemét");

            //Alg
            countKecskemet = 0;
            for (int i = 0; i < people.Count; i++) {
                if (people[i].City == "Kecskemét") { 
                    countKecskemet++;
                }
            }
            Console.WriteLine($"6. feladat: Kecskeméten: {countKecskemet} ember lakik itt");

            //7. feladat
            //LINQ
            Person under18 = people.FirstOrDefault(x => x.Age < 18);
            if (under18 != null) {
                Console.WriteLine($"...{under18}");
            }
            else { Console.WriteLine("Nincs"); }
            /**/


            //Alg
            int j = 0;
            while (j < people.Count && !(people[j].Age < 18)) { 
                    j++;
            }
            bool exist = j < people.Count;
            if (exist) {
                Console.WriteLine($"...{people[j].Name}");
            }

            //8.
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (Person person in people) {
                if (stat.ContainsKey(person.City))
                {
                    stat[person.City]++;
                }
                else {
                    stat.Add(person.City, 1);
                }
            }

            Console.WriteLine("8. feladat");
            foreach (var s in stat) { 
                Console.WriteLine($"{s.Key}- {s.Value}");
            }

            //9 feladat
            List<string> output = new List<string>();
            output.Add("Név;Kor;Város");

            foreach (var person in people) {
                if (person.Age > 25) { 
                    output.Add($"{person.Name};{person.Age};{person.City}");
                }
            }
            File.WriteAllLines("emberek25.txt", output);



        }
    }
}
