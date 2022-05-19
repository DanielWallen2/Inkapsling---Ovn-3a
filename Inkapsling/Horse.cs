using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Övn_3
{

    internal class Horse : Animal
    {
        private string race;

        public string Race
        {
            get { return race; }
            set { race = value; }
        }

        internal override string DoSound()
        {
            return "Horse sound";
        }
    }
}
