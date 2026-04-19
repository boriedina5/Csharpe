using System.Diagnostics;

namespace _11._10._5._feladat
{
    public partial class Form1 : Form
    {
        //Létrehozom a privát változót, mert ha csak az osztályban hozom létre a gomb-bal kapcsolatos fv nem tudja elérni
        private int haveToGuess;
        private int guessCount;
        private Stopwatch sw;
        public Form1()
        {
            InitializeComponent();
            Game();
        }

        //Osztályban adok értéket
        private void Game()
        {
            Random rnd = new Random();
            haveToGuess = rnd.Next(1, 100);
            guessCount = 0;
            sw = new Stopwatch();
        }
        private void submit_Click(object sender, EventArgs e)
        {
            sw.Start();
            if (!(int.Parse(number.Text) == haveToGuess))
            {
                if (int.Parse(number.Text) < haveToGuess)
                {
                    MessageBox.Show("Bigger");
                    guessCount++;
                }
                else if (int.Parse(number.Text) > haveToGuess)
                {
                    MessageBox.Show("Smaller");
                    guessCount++;
                }
            }
            else
            {
                sw.Stop();
                MessageBox.Show($"You guessed!\nYour guess count: {guessCount}\nTime: {sw}");
            }
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{haveToGuess}");
        }
    }
}
