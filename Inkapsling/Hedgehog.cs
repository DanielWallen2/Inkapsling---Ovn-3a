using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Övn_3
{
    internal class Hedgehog : Animal
    {
        private uint nrOfSpikes;

        public uint NrOfSpikes
        {
            get { return nrOfSpikes; }
            set { nrOfSpikes = value; }
        }

        internal override string DoSound()
        {
            return "Hedgehog sound";
        }
    }
}
