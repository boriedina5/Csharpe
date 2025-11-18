namespace _11._17._1._feladat
{
    public partial class Form1 : Form
    {
        Movie film;
        List<Movie> films;
        public Form1()
        {
            InitializeComponent();
            films = new List<Movie>();

        }

        public void LBS(List<Movie> filmsListP) {
            lbFilms.Items.Clear();
            foreach (var item in filmsListP) {
                lbFilms.Items.Add(item);
            }  
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(titleTB.Text)) { 
                string filmTitle = titleTB.Text;
                string filmGenre = genreCB.Text;
                int filmRelaesedYear = (int)relasedYearN.Value;

                film = new Movie(filmTitle, filmGenre, filmRelaesedYear);

                films.Add(film); //hozzáadom a listához a frissen hozzáadott filmet
                LBS(films); //frissítem a listát
                DialogResult = DialogResult.OK;
                //Close(); - mivel nem külön modulban nem kell bezárni
            
            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            if (genreCB.Text != null) { 
                string condition = genreCB.Text;
                List<Movie> searchedMovies = new List<Movie>();

                switch (condition) {
                    case "Sci-fi":
                        searchedMovies = films.Where(x => x.Genre.Contains(genreCB.Text)).ToList(); 
                        break;
                    case "Fantasy":
                        searchedMovies = films.Where(x => x.Genre.Contains(genreCB.Text)).ToList();
                        break;
                    case "Romcom":
                        searchedMovies = films.Where(x => x.Genre.Contains(genreCB.Text)).ToList();
                        break;
                }
                LBS(searchedMovies);
            }
        }
    }
}
