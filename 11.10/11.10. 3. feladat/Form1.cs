namespace _11._10._3._feladat
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> citySights = new Dictionary<string, List<string>>() {
            {"Budapest", new List<string>{"Parlament", "Halászbástya", "Hõsök tere" } },
            { "Pécs", new List<string> { "Zsolnay Negyed", "Székesegyház", "TV-torony" } },
            { "Szeged", new List<string> { "Dóm tér", "Vadaspark", "Tisza-part" } },
            { "Debrecen", new List<string> { "Nagytemplom", "Botanikus kert", "Aquaticum" } }
        };
        public Form1()
        {
            InitializeComponent();
            Cities.Items.AddRange(citySights.Keys.ToArray()); // ComboBox feltöltése városokkal
            Cities.SelectedIndexChanged += Cities_SelectedIndexChanged; //Eseménykezelõ hozzáadása
        }
        private void Cities_SelectedIndexChanged(object sender, EventArgs e) {
            string selectiedCity = Cities.SelectedItem.ToString();

            //Listbox frissítése
            sights.Items.Clear(); //elõször törlünk
            if (citySights.ContainsKey(selectiedCity)) {
                sights.Items.AddRange(citySights[selectiedCity].ToArray());//ToArray - Metódus egy új tömböt hoz létre az adott gyûjteménybõl
            }

        }





    }
}
