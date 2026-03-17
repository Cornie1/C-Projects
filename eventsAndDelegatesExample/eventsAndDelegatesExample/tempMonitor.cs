using System;
using System.Collections.Generic;
using System.Text;

namespace eventsAndDelegatesExample
{
    public delegate void TempratureAlert(string message);
    internal class tempMonitor
    {
        public event TempratureAlert OnHighTemp;

        public void CheckTemp(int temperature)
        {
            Console.WriteLine($"Current temprature: {temperature}");

            if(temperature > 30)
            {
                OnHighTemp?.Invoke("Warning! Temperature is too high!");
  
            }
        }
    }
}
