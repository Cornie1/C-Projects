using System;
using System.Collections.Generic;
using System.Text;

namespace IceTask3
{
    internal class SmartHome
    {
        public List<Device> devices = new List<Device>();

        // Event
        public event Device.DeviceAddedHandler DeviceAdded;

        public void AddDevice(Device device)
        {
            devices.Add(device);
            DeviceAdded?.Invoke($"{device.Name} added!");
        }

        public void RunAllDevices()
        {
            foreach (var d in devices)
            {
                d.TurnOn();
                Console.WriteLine(d.ShowStatus());
            }
        }

        public void TurnOffAllDevices()
        {
            foreach (var d in devices)
            {
                d.TurnOff();
                Console.WriteLine(d.ShowStatus());
            }
        }

        public void ShowAllDevices()
        {
            foreach (var d in devices)
            {
                Console.WriteLine(d.ShowStatus());
            }
        }
    }
}
