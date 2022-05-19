using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling_Övn_3
{
    internal class Person
    {
        private uint age;
        private string fName = "";
        private string lName = "";
        private double height;
        private double weight;

        public uint Age {
            get { return age; }
            set {
                if(value > 0) {
                    age = value;
                }
                else 
                {
                    throw new ArgumentException("Age must be more than 0");
                }
            }
        }

        public string FirstName {
            get { return fName; }
            set {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input. FirstName cant be spaces, empty string or null");
                }
                else if(value.Length < 2)
                {
                    throw new ArgumentException("FirstName length must be 2 or more");
                }
                else if(value.Length > 10)
                {
                    throw new ArgumentException("FirstName length cant be more than 10");
                }
                else
                {
                    fName = value; 
                }
            }
        }

        public string LastName {
            get { return lName; }
            set {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input. LastName cant be spaces, empty string or null");
                }
                else if (value.Length < 3)
                {
                    throw new ArgumentException("LastName length must be 3 or more");
                }
                else if (value.Length > 15)
                {
                    throw new ArgumentException("LastName length cant be more than 15");
                }
                else
                {
                    lName = value;
                }
                
            }
        }

        public double Height {
            get { return height; }
            set {
                if (value > 0) { height = value; }
                else 
                {
                    throw new ArgumentException("Height must be more than 0");
                }
            }
        }

        public double Weight {
            get { return weight; }
            set {
                if (value > 0) { weight = value; }
                else
                {
                    throw new ArgumentException("Weight must be more than 0");
                }
            }
        }

    }
}
