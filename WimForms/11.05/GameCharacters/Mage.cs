using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacters
{
    public class Mage : Character //Addig húzza alá, mert még az Ősosztály konstruktorát
    {
        public int Mana { get; set; }
        public Mage(string n, int hp, int lvl, int dmg, int mana) :base(n, hp, lvl, dmg)
        { 
            Mana = mana;
        }
        public override void Attack()
        {
            base.Attack();
            MessageBox.Show($"{Name} does magic");
        }

        public override string ToString()
        {
            return $"Mage: {Name}, {Hp}, {Level}, {Dmg}, {Mana}";
        }
    }
}
