namespace FutasConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //beolvasás
            var runningFile = File.ReadAllLines("futas.txt").Skip(1);
            List<Futas> runners = new List<Futas>();
            foreach (var item in runningFile)
            {
                runners.Add(new Futas(item));
            }

            //3. feladat
            Console.WriteLine($"3. feladat: {runners.Count} versenyző van");

            //4. feladat
            int differentCityCount = 0;
            
            Dictionary<string, int> cityCount = new Dictionary<string, int>();
            foreach (var item in runners) { 
                if(cityCount.ContainsKey(item.City)) {
                    cityCount[item.City]++;
                } else {
                    cityCount.Add(item.City, 1);
                }
            }
            foreach (var item in cityCount.Keys) {
                differentCityCount++;
            }
            Console.WriteLine($"4. feladat: {differentCityCount} különböző város");

            //5. feladat
            int maxCityCount = 0;
            string maxCity = "";
            foreach (var item in cityCount)
            {
                if(item.Value > maxCityCount) {
                    maxCityCount = item.Value;
                    maxCity = item.Key;
                }
            }
            Console.WriteLine($"5. feladat: A legtöbb versenyző innen: {maxCity}");

            //6. feladat
            var runnersABC = runners.OrderBy(x => x.Name).ToList();
            Console.WriteLine($"6. feladat: {runnersABC.First().Name} ({runnersABC.First().RunningTime})");

            //7. feladat
            int kLetterCounter = 0;
            for (int i = 0; i < runners.Count; i++) {
                if (runners[i].Name.StartsWith("K")) {
                    kLetterCounter++;
                }
            }
            if (kLetterCounter == 0)
            {
                Console.WriteLine("7. feladat: Nincs K betűvel kezdődő nevű versenyző");
            }
            else {
                Console.WriteLine($"7. feladat: {kLetterCounter} versenyző neve kezdődik K betűvel");
            }

            //8. feladat
            Dictionary<string, int> runnersName = new Dictionary<string, int>();
            foreach (var item in runners) { 
                if(runnersName.ContainsKey(item.Name)) {
                    runnersName[item.Name]++;
                } else {
                    runnersName.Add(item.Name, 1);
                }
            }
            bool sameName = false;
            foreach (var item in runnersName) { 
                if(item.Value > 1) {
                    sameName = true;
                }
            }
            if (sameName == true) {
                Console.WriteLine("8. feladat: Van azonos nevű versenyző");
            }
            else{
                Console.WriteLine("8. feladat: Nincs azonos nevű versenyző");
            }

            //9. feladat
            Console.WriteLine("9. Feladat: Város statisztika");
            foreach (var item in cityCount) { 
                Console.WriteLine($"{item.Key} - {item.Value} fő");
            }

            //10. feladat
            List<string> runnersFromBp = new List<string>();
            runnersFromBp.Add("Név;Város;Idő");
            for (int i = 0; i < runners.Count; i++) {
                if (runners[i].City == "Budapest") {
                    runnersFromBp.Add($"{runners[i].Name};{runners[i].City};{runners[i].RunningTime}");
                }
            }
            File.WriteAllLines("budapest.txt", runnersFromBp);

            Console.WriteLine("10. feladat: budapest.txt elkészült");

        }
    }
}
