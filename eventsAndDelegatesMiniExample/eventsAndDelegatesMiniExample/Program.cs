namespace eventsAndDelegatesMiniExample
{
    internal class Program
    {
        static void Subscriber1()
        {
            Console.WriteLine("Subscriber 1 recieved notification");
        }
        static void Subscriber2() 
        {
            Console.WriteLine("Subscriber 2 recieved notification");
        }
        static void Main(string[] args)
        {
            publisher pub = new publisher();

            //4. Subscribe multiple methods
            pub.OnProcessCompleted += Subscriber1;
            pub.OnProcessCompleted += Subscriber2;

            pub.RunProcess();

            Console.ReadLine();

        }
    }
}
