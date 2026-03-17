using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleActivity
{
    class Truck : VehicleClass
    {
        public int loadcapacity { get; set; }
        public override int HowManyPassengers()
        {
            return 2;
        }
    }
}
