using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftHero
{
    class Helmet
    {
        int protection;

        public int Protection
        {
            get { return this.protection; }
        }

        public Helmet(int protection)
        {
            this.protection = protection;
        }
    }
}
