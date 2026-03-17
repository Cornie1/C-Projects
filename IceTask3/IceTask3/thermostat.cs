using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace IceTask3
{
    internal class thermostat : Device
    {
        public int Temprature { get; set; }

        public override void TurnOn()
        {
            IsOn = true;
            Temprature = 50;
        }

        public override void TurnOff()
        {
            IsOn = false;
            Temprature = 0;
        }
        public override string ShowStatus()
        {
            return $"{Name} is {(IsOn ? "ON" : "OFF")} with Temprature {Temprature}";
        }
    }
}
