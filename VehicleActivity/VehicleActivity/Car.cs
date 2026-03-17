using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleActivity
{
    class Car : VehicleClass
    {
        public int DoorAmount { get; set; }
        public override int HowManyPassengers()
        {
            return 5;
        }
    }
}
