using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacters
{
    public class Warrior : Character
    {
        public int Energy { get; set; }

        public Warrior(string n, int hp, int lvl, int dmg, int en) : base(n, hp, lvl, dmg) { 
            Energy = en;
        }
        public override void Attack()
        {
            MessageBox.Show($"{Name} swings their sword");
        }
        public override string ToString()
        {
            return $"Mage: {Name}, {Hp}, {Level}, {Dmg}, {Energy}";
        }
    }
}
