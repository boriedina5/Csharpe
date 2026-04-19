using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCharacters
{
    public class Character
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Level { get; set; }
        public int Dmg { get; set; }
        public Character(string n, int hp, int lvl, int dmg)
        { //akkor hívodik meg, ha a Characterből konkrét példány lesz -> emiatt jön létre a példány
            Name = n;
            Hp = hp;
            Level = lvl;
            Dmg = dmg;
        }
        public virtual void Attack() {//virtual - felülírható metódus
            MessageBox.Show($"{Name} attacks.");


        }
    }
}
