namespace _2._feladat
{
    public partial class Form1 : Form
    {
        List<Tetel> tetelLista;
        Tetel ujtetel;

        public Form1()
        {
            InitializeComponent();
            tetelLista = new List<Tetel>();
            LVShow(tetelLista); 
        }

        public void LVShow(List<Tetel> peldanyLista) { 
            lvBevasarloLista.Clear();
            foreach (var item in peldanyLista) {
                lvBevasarloLista.Items.Add(item.ToString());
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            string tetelNeve = tetelNeveTB.Text;
            int tetelMennyisege = (int)tetelMennyisegeN.Value;
            int tetelEgysegar = (int)tetelegysegaraN.Value;

            ujtetel = new Tetel(tetelNeve, tetelMennyisege, tetelEgysegar);

            DialogResult = DialogResult.OK;
            tetelLista.Add(ujtetel);
            LVShow(tetelLista);
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            int vegosszeg = 0;
            for (int i = 0; i < tetelLista.Count; i++) {
                vegosszeg += tetelLista[i].TetelMennyiseg * tetelLista[i].TetelEgysegara;
            }
            vegosszeglb.Text = $"Végösszeg: {vegosszeg.ToString()}";

        }
    }
}
