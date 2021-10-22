using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftHero
{
    class Armour
    {
        int protection;
        Helmet helmet;
        Shield shield;

        public int Protection
        {
            get { return this.protection; }
        }

        public Armour(int protection)
        {
            this.helmet = new Helmet(protection/10);
            this.shield = new Shield(protection / 6);

            this.protection = protection + helmet.Protection + shield.Protection;
        }

    }
}
