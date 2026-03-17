using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class AnimalClass
    {
        public string name { get; set; }
        public int numOflegs { get; set; }
        public string tail { get; set; }
        public string diet { get; set; }

        public abstract string Speak();
        public virtual string CanFly()
        {
            return "i can fly";
        }

        public string DisplayInfo()
        {
            return $"{name}\t{numOflegs}\t{tail}\t{diet}\t" + CanFly();
        }


    }
}
