using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Övn_3
{
    internal class Bird : Animal
    {
        // F: Om vi under utvecklingen kommer fram till att samtliga
        // fåglar behöver ett nytt attribut, lägger vi in det här!

        private double wingSpan;

        public double WingSpan
        {
            get { return wingSpan; }
            set { wingSpan = value; }
        }

        internal override string DoSound()
        {
            return "Chirp";
        }
    }
}
