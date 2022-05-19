using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Övn_3
{
    internal abstract class Animal
    {
        // F: Om alla djur behöver det nya attributet, lägger vi in det här

        private string name;
        private double weight;
        private uint age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public uint Age
        {
            get { return age; }
            set { age = value; }
        }

        internal Animal() { }
        //internal Animal(string Name, double Weight, uint Age)
        //{
        //    this.Name = Name;
        //    this.Weight = Weight;
        //    this.Age = Age;
        //}

        internal abstract string DoSound();
        internal virtual string Stats()
        {
            return $"Name, Weight, Age";
        }

            

    }
}
