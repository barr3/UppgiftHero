using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftHero
{
    class Shield
    {
        int protection;

        public int Protection
        {
            get { return this.protection; }
        }

        public Shield(int protection)
        {
            this.protection = protection;
        }
    }
}
