namespace eventsAndDelegatesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tempMonitor monitor = new tempMonitor();

            alertsystem alert = new alertsystem();

            //4. Subscribe to the event
            monitor.OnHighTemp += alert.ShowAlert;

            monitor.CheckTemp(25);
            monitor.CheckTemp(35);

            Console.ReadLine();
        }
    }
}
