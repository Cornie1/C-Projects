using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class reptileClass : AnimalClass
    {
        public string scales {  get; set; }
        public override string Speak()
        {
            return "Does make a sound";
        }
    }
}
