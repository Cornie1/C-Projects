using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleActivity
{
    abstract class VehicleClass
    {
        public string brand { get; set; }
        public int numOfWheels { get; set; }
        public string colour { get; set; }
        public string FuelType { get; set; }
        public virtual int HowManyPassengers()
        {
            return 0;
        }
        public string DisplayInfo()
        {
            return $"Make of the vehicle: {brand}\t Number of wheels: {numOfWheels}\tColour of vehicle: {colour}\t The Fuel Type: {FuelType}\t" +"\nAmount of Passengers: "+ HowManyPassengers();
        }
    }
}
