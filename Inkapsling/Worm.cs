using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Övn_3
{
    internal class Worm : Animal
    {
        private bool isPoisonous;

        public bool IsPoisonous
        {
            get { return isPoisonous; }
            set { isPoisonous = value; }
        }

        internal override string DoSound()
        {
            return "Hissss";
        }
    }
}
