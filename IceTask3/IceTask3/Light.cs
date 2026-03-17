using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace IceTask3
{
    internal class Light : Device
    {
        public int Brightness { get; set; }

        public override void TurnOn()
        {
            IsOn = true;
            Brightness = 100;
        }

        public override void TurnOff()
        {
            IsOn = false;
            Brightness = 0;
        }

        public override string ShowStatus()
        {
            return $"{Name} is {(IsOn ? "ON" : "OFF")} with brightness {Brightness}";
        }
    }
}
