using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEventsActivity
{
    internal class Alert
    {
        public void ShowAlert(string message)
        {
            Console.WriteLine("Alert: " + message);
        }
    }
}
