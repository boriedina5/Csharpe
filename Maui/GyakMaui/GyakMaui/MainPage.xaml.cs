using GyakMaui.Models;//beilleszted a model osztályt
using GyakMaui.Context;//beilleszted a context osztályt

namespace GyakMaui
{
    public partial class MainPage : ContentPage
    {
        private AppDatatbase DataBase;//beilleszted az adatbázis osztályt

        public MainPage()
        {
            InitializeComponent();
            DataBase = new AppDatatbase();
            LoadView();
        }
        private void LoadView() { 
        
        }
        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            StepperLabel.Text = $"{e.NewValue:F0}"; //F0: egész számként jeleníti meg a lépés értékét
        }

        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TitleEntry.Text) && !string.IsNullOrEmpty(AuthorEntry.Text)) {
                Book newBook = new Book
                {
                    Title = TitleEntry.Text,
                    Author = AuthorEntry.Text,
                    Year = (int)YearStepper.Value
                };
                DataBase.Books.Add(newBook);
                DataBase.SaveChanges();
                LoadView();
            }
        }

        private void SortBtn_Clicked(object sender, EventArgs e)
        {
            BooksCollectionView.ItemsSource = DataBase.Books.OrderBy(b => b.Title).ToList();
        }

        private void ResetBtn_Clicked(object sender, EventArgs e)
        {
            LoadView();
        }
    }
}
