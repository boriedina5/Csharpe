using System.Globalization;

namespace _3._feladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Fájl kiválasztása";
            ofd.Filter = "TXT files (*.txt)|*.txt|All files (*.*)|*.*";


            if (ofd.ShowDialog() == DialogResult.OK) { 
                string file = ofd.FileName;
                string[] rows = File.ReadAllLines(file);
                List<int> ints = new List<int>();

                foreach (string row in rows) { 
                    ints.Add(int.Parse(row));
                    listBox1.Items.Add(row);
                }

            }
        }
    }
}
