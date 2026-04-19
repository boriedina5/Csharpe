using QuizzApp.Models;
using QuizzApp.Context;
using System.Drawing.Text;

namespace QuizzApp
{
    public partial class Form1 : Form
    {
        AppDatabase Database;
        List<Question> dailyQuestion;
        int currentQuestionIndex = 0;
        int correctCount = 0;
        int timeLeft; //visszamaradt idõt ide mentjük
        const int QuestionTimeLimit = 1000; //max msp a kérdésre, millisecond-ben van
        public Form1()
        {
            Database = new AppDatabase();
            InitializeComponent();
            StartQuiz();
        }
        private void StartQuiz()
        {
            var today = DateTime.Now;
            bool alreadyPlayed = Database.UserResults.Any(u => u.Date == today);
            //Any: egy egyszerû eldöntendõ kérdést tesz fel az adatbázisnak:
            //„Van-e legalább egy olyan elem, ami megfelel a feltételnek?”

            if (alreadyPlayed)
            {
                MessageBox.Show("You have already played today's quiz. Come back tomorrow!");
                this.Close();//lzárja az ablakot
                return;//lezárja a futást/programot
            }

            dailyQuestion = Database.Questions.
                OrderBy(q => Guid.NewGuid()).//Ne kerüljön be két ugyanolyan kérdés az adatbázisból
                Take(5).
                ToList();

            ShowQuestion();

        }
        private void ShowQuestion()
        {
            var q = dailyQuestion[currentQuestionIndex];

            lQuestion.Text = q.Text;
            rbtnA.Text = q.AnswerA;
            rbtnB.Text = q.AnswerB;
            rbtnC.Text = q.AnswerC;
            rbtnD.Text = q.AnswerD;
            //Átadjuk a labelnek a kérdés szövegét és a radiobuttonoknak a válaszokat
            rbtnA.Checked = rbtnB.Checked = rbtnC.Checked = rbtnD.Checked = false; //mitha 4 külön sorba írtam volna
            lProgress.Text = $"{currentQuestionIndex + 1} / {dailyQuestion.Count}"; //Aktuális kérdés száma / Összes kérdés száma a labelben

            //Akkor induljon el az idõzítõ ha megjelenik a kérdés
            timeLeft = QuestionTimeLimit; //10 másodperc lesz a maradék idõ
            lFeedBack.Text = $"Time left: {timeLeft} seconds";
            quizTimer.Start(); //elindítjuk az idõzítõt;
        }

        private void btnNext_Click(object sender, EventArgs e)//Kiválasztott válasz mentése
        {
            /*string selectedAnswer = null;

            if (rbtnA.Checked) selectedAnswer = "A"; //Ha egy utasítás van, akkor elhagyható a {}
            if (rbtnB.Checked) selectedAnswer = "B";
            if (rbtnC.Checked) selectedAnswer = "C";
            if (rbtnD.Checked) selectedAnswer = "D";
            //Elmentjük a kiválasztott választ

            if (selectedAnswer == null)//Ha nem választott semmit
            {
                MessageBox.Show("Please select an answer before proceeding.");
                return;//befejezi a metódust
            }
            //correct válasz ellenõrzése
            if (selectedAnswer == dailyQuestion[currentQuestionIndex].CorrectAnswer)
            {
                correctCount++;
            }
            currentQuestionIndex++;

            //Túlindexelés kezelése

            if (currentQuestionIndex < dailyQuestion.Count)
            {
                ShowQuestion();//folytatódik a kérdéssor
            }
            else
            {
                FinishQuiz();//befejezõdik a kérdéssor
            } -- Next Question-ba átkerült */

            quizTimer.Stop(); //leállítjuk az idõzítõt
            NextQuestion();//meghívjuk a NextQuestion metódust

        }

        private void NextQuestion(bool timeExpired = false) {//opcionális paraméter 
            if (!timeExpired)//ha hamis
            {//figyelem, hogy lejárt-e az idõ vagy sem
                string selectedAnswer = null;

                if (rbtnA.Checked) selectedAnswer = "A"; //Ha egy utasítás van, akkor elhagyható a {}
                if (rbtnB.Checked) selectedAnswer = "B";
                if (rbtnC.Checked) selectedAnswer = "C";
                if (rbtnD.Checked) selectedAnswer = "D";
                //Elmentjük a kiválasztott választ

                if (selectedAnswer == null)//Ha nem választott semmit
                {
                    MessageBox.Show("Please select an answer before proceeding.");
                    return;//befejezi a metódust
                }
                //correct válasz ellenõrzése
                if (selectedAnswer == dailyQuestion[currentQuestionIndex].CorrectAnswer)
                {
                    correctCount++;
                }
                currentQuestionIndex++;

                //Túlindexelés kezelése
                if (currentQuestionIndex < dailyQuestion.Count)
                {
                    ShowQuestion();//folytatódik a kérdéssor
                }
                else
                {
                    FinishQuiz();//befejezõdik a kérdéssor
                }
            }

        }
        private void FinishQuiz()
        {
            var result = new UserResult //létrehozzunk egy új felhasználót -> tároljuk az eredményt
            {
                Date = DateTime.Now,
                CorrectAnswers = correctCount,

            };


            Database.UserResults.Add(result);//Hozzáadjuk az eredményt az adatbázishoz
            Database.SaveChanges();//elmentjük az eredményt az adatbázisba
            MessageBox.Show($"Quiz finished! You answered {correctCount} out of {dailyQuestion.Count} questions correctly.");
            this.Close();//lezárja az ablakot, this elhagyható, de az aktuális osztályt jelöli
        }

        private void quizTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lFeedBack.Text = $"Time left: {timeLeft} seconds";
            if (timeLeft <= 300) {
                lFeedBack.ForeColor = Color.Red; //pirosra vált a szöveg, ha 3 mp van hátra
            }
            if (timeLeft == 0) { 
                quizTimer.Stop();//leállítjuk az idõzítõt
                NextQuestion(timeExpired: true); //automatikusan továbblépünk a következõ kérdésre,
                                                 //timeExpired: true - nevesített paraméter (named argument),
                                                 //A NextQuestion metódusodnak valószínûleg van egy bool típusú bemenõ paramétere.
                                                 //Ha csak annyit írnál, hogy NextQuestion(true);,
                                                 //egy idegen (vagy te magad két hét múlva) nem tudná kapásból,
                                                 //mit jelent az a "true". Így viszont: NextQuestion(timeExpired: true);
                                                 //– egyértelmû, hogy azért ugrunk a következõ kérdésre, mert lepergett az idõ.
            }
        }
    }
}
