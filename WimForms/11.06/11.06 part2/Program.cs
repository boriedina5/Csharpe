namespace _11._06_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> numbers = new List<int>();
           string[] rows = File.ReadAllLines("input.txt");
           foreach (string row in rows) {
                numbers.Add(int.Parse(row));
           }
           //Van-e a sorozatban pozitív szám?
           bool positive = false;
           int index = 0;
            while (index < numbers.Count && !(numbers[index] > 0))
            {
                index++;
            }
            positive = index < numbers.Count;
            Console.WriteLine(positive);
            
            //Hány eleme van a sorozatnak ?
            int listElementCount = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                listElementCount++;
            }
            Console.WriteLine(listElementCount);

            // Mennyi a sorozatban található legkisebb szám?
            int min = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (min > numbers[i]) { 
                    min = numbers[i];
                }
            }
            Console.WriteLine(min);

            //Mennyi a sorozatban található számok átlagának a fele?
            int sum = 0;
            for (int i = 1; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum / numbers.Count / 2);

            //Igaz-e, hogy minden szám pozitív?
            bool existNegativ = false;
            index = 0;
            while (index < numbers.Count && !(numbers[index] < 0))
            {
                index++;
            }
            existNegativ = index < numbers.Count;
            Console.WriteLine(existNegativ);

            //Hány páratlan szám található a sorozatban?
            int listUeElementCount = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 1) {
                    listUeElementCount++;
                }
            }
            Console.WriteLine(listUeElementCount);

            //Van-e a sorozatban olyan negatív szám, amelyet újabb negatív követ?
            bool existThisSen = false;
            index = 1;

            while (index < numbers[index] && !(numbers[index-1] < 0 && numbers[index] < 0)) { 
                index++;
            }
            existThisSen = index < numbers.Count;
            Console.WriteLine(existThisSen);

            //Írjuk ki az utolsó 19-tel osztható szám indexét!
            int dIndex = 0;
            for (int i = 0; i < numbers.Count; index++)
            {
                if (numbers[i] % 19 == 0)
                {
                    dIndex = i;
                }
            }
            Console.WriteLine(dIndex);
            //Írjuk ki a sorozatban található 5-tel osztható számokat!
            List<int> dividedFive = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 5 == 0)
                {
                    dividedFive.Add(numbers[i]);
                }
            }
            for (int i = 0; i < dividedFive.Count; i++)
            {
                Console.WriteLine(dividedFive[i]);
            }
        }
    }
}
