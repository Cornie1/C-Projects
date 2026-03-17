using System;
using System.Collections.Generic;
using System.Text;

namespace eventsAndDelegatesMiniExample
{//1. Declare delegate
    public delegate void Notify();
    internal class publisher
    {

        //2. Declare event
        public event Notify OnProcessCompleted;  //this is an event of type Notify

        public void RunProcess() //this method will trigger the event when the process is completed
        {
            Console.WriteLine("Process is running...");
            Console.WriteLine(" Process is finished! \n");

            //3. Raise the event

            OnProcessCompleted?.Invoke(); //this will call all the methods that are subscribed to the event . ? means it could be null if no one is subscribed to the event, so we check for null before invoking it.

        }

    }
}