namespace GameCharacters
{
    public partial class Form1 : Form
    {
        List<Character> characters;
        public Form1()
        {
            InitializeComponent();
            characters = new List<Character>();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EnergyOrMana_Click(object sender, EventArgs e)
        {

        }

        private void Gomb_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                string name = textBox1.Text;
                int hp = (int)Hp.Value;
                int lvl = (int)Level.Value;
                int dmg = (int)Dmg.Value;

                if (MargeC.Checked)
                {
                    int mana = (int)EnergyOrMannaC.Value;
                    Mage newMage = new Mage(name, hp, lvl, dmg, mana);
                    characters.Add(newMage);
                }
                else
                {
                    int en = (int)EnergyOrMannaC.Value;
                    Warrior newWarrior = new Warrior(name, hp, lvl, dmg, en);
                    characters.Add(newWarrior);
                }
                lbCharacters.Items.Clear();
                foreach (var character in characters)
                {
                    lbCharacters.Items.Add(character);
                }

            }
        }

        private void Attack_Click(object sender, EventArgs e)
        {
            if (lbCharacters.SelectedItem != null) { 
                int ind = lbCharacters.SelectedIndex;
                characters[ind].Attack();
            }
        }
    }
}
