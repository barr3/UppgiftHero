using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftHero
{
    class Sword
    {
        int damage;

        public int Damage
        {
            get { return this.damage; }
        }

        public Sword(int damage)
        {
            this.damage = damage;
        }
    }
}
