using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Övn_3
{
    internal class Wolfman : Wolf, IPerson
    {

        public string Talk()
        {
            return "I am Wolfman...";
        }
    }
}
