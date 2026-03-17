using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Checker
{
    internal class VehicleClass
    {
        public string name { get; set; }
        public string VehicleType { get; set; }
        public string Colour { get; set; }
        public int AmountofWheels { get; set; }
        public string TypeOfFuel { get; set; }

        public VehicleClass(string name, string vehicleType, string colour, int amountofWheels, string typeOfFuel)
        {
            this.name = name;
            this.VehicleType = vehicleType;
            this.Colour = colour;
            this.AmountofWheels = amountofWheels;
            this.TypeOfFuel = typeOfFuel;
        }

        public string display()
        {
            return "\n Your name is: " +name + "\n Your vehicle type is:  " + VehicleType + "\n Your Vehicle colour is: " + Colour + "\n The amount of wheels u have is: " + AmountofWheels+ "\n The type of fuel u use: " + TypeOfFuel;
        }
    }
}
