namespace _11._19
{
    public partial class Form1 : Form
    {
        List<Feladat> feladatokListaja; 
        public Form1()
        {
            InitializeComponent();
            feladatokListaja = new List<Feladat>()
            {
                new Feladat("Mosogatás", new DateTime(2025, 12, 19, 20, 00, 00), 3),
                new Feladat("Porszívózás", new DateTime(2025, 11, 20, 15, 00, 00), 4),
                new Feladat("Horgolás", new DateTime(2025, 11, 30, 12, 00, 00), 2)

            };
            LBS(feladatokListaja);
        }

        public void LBS(List<Feladat> feladatokListajaPeldany) { 
            lbFeladatkezelo.Items.Clear();
            foreach(var item in feladatokListajaPeldany) { 
                 lbFeladatkezelo.Items.Add(item);
            }

        }
        private void rendezesBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rendezesCB.Text)) { 
                string szempont = rendezesCB.Text;
                if (szempont == "Határidõ")
                {
                    LBS(feladatokListaja.OrderBy(f => f.Hatarido).ToList());

                }
                else if (szempont == "Priorítás") {
                    LBS(feladatokListaja.OrderBy(f => f.Prioritas).ToList());
                }
            }
        }

        private void lbFeladatkezelo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbFeladatkezelo.SelectedItem != null) {
                int index = lbFeladatkezelo.SelectedIndex;
                feladatokListaja.Remove(feladatokListaja[index]);
                LBS(feladatokListaja.OrderBy(f => f.Prioritas).ToList());
            }
        }
    }
}
