using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Övn_3
{
    internal class Flamingo : Bird
    {
        private bool isDancing;

        public bool IsDancing
        {
            get { return isDancing; }
            set { isDancing = value; }
        }

    }
}
