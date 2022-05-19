using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Övn_3
{
    internal class Wolf : Animal
    {
        private bool isBig;
        private bool isBad;

        public bool IsBig
        {
            get { return isBig; }
            set { isBig = value; }
        }
        public bool IsBad
        {
            get { return isBad; }
            set { isBad = value; }
        }

        internal override string DoSound()
        {
            return "Howl";
        }

    }
}
