namespace _1._feladat
{
    public partial class Form1 : Form
    {
        List<Tantargyjegyzek> tantargyjegyzekLista;
        public Form1()
        {
            InitializeComponent();
            tantargyjegyzekLista = new List<Tantargyjegyzek> {
                new Tantargyjegyzek("Matek", 4, "Szabó Imre" ),
                new Tantargyjegyzek("Magyar", 5, "Kovács Béla"),
                new Tantargyjegyzek("Történelem", 3, "Kocsis Judit")
            };
            ListViewShow(tantargyjegyzekLista);
        }

        public void ListViewShow(List<Tantargyjegyzek> peldanyLista) { 
            lvTantargyjegyzek.Items.Clear();
            foreach (var item in peldanyLista ) {
                lvTantargyjegyzek.Items.Add(item.ToString()); //ide kell a ToString()
            }
        }

        private void szerkesztesBTN_Click(object sender, EventArgs e)
        {
            /*if (lvTantargyjegyzek.SelectedItems.Count > 0) { 
                
            }*/
        }

        private void torlesBTN_Click(object sender, EventArgs e)
        {

        }

        private void keresesBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tanarNeveTB.Text) ) { 
                List<Tantargyjegyzek> results = tantargyjegyzekLista.Where(x => x.TanarNeve == tanarNeveTB.Text).ToList();
                ListViewShow(results);
            }
            
        }
    }
}
