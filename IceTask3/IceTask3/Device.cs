using System;
using System.Collections.Generic;
using System.Text;

namespace IceTask3
{
    public class Device : ISwitchable
    {
        public string Name { get; set; }
        public bool IsOn { get; set; }

        // Delegate
        public delegate void DeviceAddedHandler(string message);

        // Virtual methods
        public virtual void TurnOn()
        {
            IsOn = true;
        }

        public virtual void TurnOff()
        {
            IsOn = false;
        }

        public virtual string ShowStatus()
        {
            return $"{Name} is {(IsOn ? "ON" : "OFF")}";
        }
    }
}
