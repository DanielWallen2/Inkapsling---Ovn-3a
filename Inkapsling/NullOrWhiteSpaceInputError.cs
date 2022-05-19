using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Övn_3
{
    internal class NullOrWhiteSpaceInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried input an empty string, space, tab or null. This fired an error!";
        }
    }
}
