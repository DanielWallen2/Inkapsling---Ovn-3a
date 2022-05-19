using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Övn_3
{
    internal class Swan : Bird
    {
        private bool isMoulting;

        public bool IsMoulting
        {
            get { return isMoulting; }
            set { isMoulting = value; }
        }

    }
}
