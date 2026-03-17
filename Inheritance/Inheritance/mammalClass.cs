using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class mammalClass : AnimalClass
    {
        public string furType { get; set; }
        public override string CanFly()
        {
            return "I cannot fly: ";
        }
        public override string Speak()
        {
            return "Does make a sound: ";
        }
    }
}
