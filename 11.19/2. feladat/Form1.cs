namespace _2._feladat
{
    public partial class Form1 : Form
    {
        //GridView - táblázatos megjelenítés
        List<Person> peopleList;
        public Form1()
        {
            InitializeComponent();
            peopleList = new List<Person>();
            {
                new Person{Name = "Kis Géza", Age= 24, Phone = "3423102334" };
                new Person { Name = "Nagy Marci", Age = 25, Phone = "3423102335" };

            }
            dataGridView1.DataSource = peopleList; //átadjuk a listát*/
        }

        
    }
}
