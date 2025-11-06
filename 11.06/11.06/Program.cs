using System.ComponentModel;

namespace _11._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            //beolvasás
                string[] rows = File.ReadAllLines("input.txt");
                foreach(string row in rows)
                {
                    numbers.Add(int.Parse(row));
                }

            //Hány eleme van a sorozatnak?
                int listElementCount = 0;
                for (int i = 0; i < numbers.Count; i++) { 
                    listElementCount++;
                }
                Console.WriteLine(listElementCount);

            //Van-e a sorozatban negatív szám
            bool exist = false;
                int index = 0;
                while (index < numbers.Count && !(numbers[index] < 0))
                {
                    index++;
                }
                exist = index < numbers.Count;
                Console.WriteLine(exist);

                //LINQ műveletek - lambda kifejezést vár műveletnek
                exist = numbers.Any(x => x < 0);// x = az a szám, amit vizsgálunk a tömbböl
                Console.WriteLine(exist);

            //Hány páros szám van a sorozatban
                int count = 0;
                for (int i = 0; i < numbers.Count; i++) {
                    if (numbers[i] % 2 == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                //LINQ
                count = numbers.Count(x => x % 2 == 0);
            //Mennyi a sorozatban található legnagyobb szám?
                int maxValue = numbers[0];
                for (int i = 1; i < numbers.Count; i++) { 
                    if (numbers[i] > maxValue)
                    {
                        maxValue = numbers[i];
                    }
                }
                Console.WriteLine(maxValue);
                //LINQ
                maxValue = numbers.Max();
                Console.WriteLine(maxValue);

            //Írjuk ki a sorozatban található 10-zel osztható számokat!
                List <int> dividedTen = new List<int>();
                for (int i = 0; i < numbers.Count; i++) {
                if (numbers[i] % 10 == 0) { 
                    dividedTen.Add(numbers[i]);
                }
                }
                for (int i = 0; i < dividedTen.Count; i++)
                {
                    Console.WriteLine(dividedTen[i]);
                }
                
                //Írjuk ki az első 29-cel osztható szám indexét! - Kiválasztás
                index = 0;
                while (!(numbers[index] % 29 == 0)) {
                    index++;
                }
                Console.WriteLine(index);
                //LINQ
                index = numbers.FindIndex(x => x % 29 == 0);
            //Igaz-e, hogy minden szám páros?
                bool isThereUnequalledNumber = false;
                index = 0;
                while (index < numbers.Count && !(numbers[index] % 2 == 1)) { 
                    index ++;
                }
                isThereUnequalledNumber = index < numbers.Count;

            // Mennyi a sorozatban található számok átlaga?
            int s = 0;
                for (int i = 0; i < numbers.Count; index++) {
                    s += i;
                }
                Console.WriteLine((double)s / numbers.Count);
                //LINQ
                s = numbers.Sum();
                Console.WriteLine((double)s / numbers.Count);

            //Írjuk ki az utolsó 17-tel osztható szám indexét!
            
            int dIndex = 0;
            for (int i = 0; i < numbers.Count; index++)
            {
                if (numbers[i] % 17 == 0) {
                    
                    dIndex = i;
                }
            }
            Console.WriteLine(dIndex);
            //LINQ
            s = numbers.Sum();
            Console.WriteLine((double)s / numbers.Count);
            // Írjuk ki az első 33-mal osztható szám indexét! - keresés
            exist = false;
                index = 0;
                while (index < numbers.Count && !(numbers[index] % 33 == 0 )) {
                    index++;
                }
                exist = index < numbers.Count; ;
                string output = exist ? $"Van {index}. helyen" : "Nincs";
                Console.WriteLine(output);
                //LINQ
                exist = numbers.Any(x => x % 33 == 0);
                if(exist){
                    index = numbers.FindIndex(x => x % 33 == 0);
                    Console.WriteLine(index);
                }
            

        }
    }
}
