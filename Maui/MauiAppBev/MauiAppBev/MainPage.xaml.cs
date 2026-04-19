namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ColorEntry.Text))
            {
                Random rnd = new Random();
                int r = rnd.Next(0, 256);
                int g = rnd.Next(0, 256);
                int b = rnd.Next(0, 256);

                var color = Color.FromRgb(r, g, b);
                RootLayout.BackgroundColor = color;
                ColorLabel.Text = $"RGB: {r}, {g}, {b}";
            }
            else
            {
                var color = Color.Parse(ColorEntry.Text);
                RootLayout.BackgroundColor = color;
                ColorLabel.Text = $"{color.Red}, {color.Green}, {color.Blue}";
            }



        }
    }
}