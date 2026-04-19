namespace _5._feladat
{
    public partial class Form1 : Form
    {
        List<Tanulo> tanulokLista;
       
        Tanulo ujTanulo;
        public Form1()
        {
            InitializeComponent();
            tanulokLista = new List<Tanulo>();
            LBS(tanulokLista);
        }

        public void LBS(List<Tanulo> peldanyLista) { 
            lbNaplo.Items.Clear();
            foreach (var item in peldanyLista) { 
                lbNaplo.Items.Add(item);
            }
        }
        private void ujTanuloHozzadasaBTN_Click(object sender, EventArgs e)
        {
            string nev = ujNevTB.Text;
            string tantargyneve = ujTantargyTB.Text;
            List<int> jegyekListaja = new List<int>();
            jegyekListaja.Add((int)ujJegyN.Value);

            ujTanulo = new Tanulo(nev, tantargyneve, jegyekListaja);
            tanulokLista.Add(ujTanulo);
            LBS(tanulokLista);
        }

        private void jegyHozzadasaBTN_Click(object sender, EventArgs e)
        {
            if (lbNaplo.SelectedItem != null) {
                Tanulo kivalasztott = (Tanulo)lbNaplo.SelectedItem;

                int ujJegy = (int)jegyN.Value;
                kivalasztott.Jegyek.Add(ujJegy);

                LBS(tanulokLista);
            }
        }

        private void atlagSzamolasBTN_Click(object sender, EventArgs e)
        {
            if (lbNaplo.SelectedItem != null)
            {
                Tanulo kivalasztott = (Tanulo)lbNaplo.SelectedItem;

                double atlag = kivalasztott.Jegyek.Average();
                atlagL.Text = $"Tanuló átlaga {atlag}";
                LBS(tanulokLista);
            }
        }
    }
}
