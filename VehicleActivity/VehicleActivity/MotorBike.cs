using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleActivity
{
    class MotorBike : VehicleClass
    {
        public string HasSideCar { get; set; }

        public override int HowManyPassengers()
        {
            return 2;
        }
    }
}
