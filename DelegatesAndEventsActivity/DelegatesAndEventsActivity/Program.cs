namespace DelegatesAndEventsActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankCheck NB = new BankCheck();
            Alert alert = new Alert();
            double balance = 500;
            NB.OnLowBalance += alert.ShowAlert;
            bool Running = true;
            while (Running)
            {
                Console.WriteLine("\n1: Check your Balance: " +
                                       "\n2: Withdraw from your Account: " +
                                       "\n3: Exit the Program:" +
                                       "\n-------------------------- ");
                int Userinput = int.Parse(Console.ReadLine());
                switch (Userinput)
                {
                    case 1:
                        Console.WriteLine("Check Your Balance: " + balance);

                        break;
                    case 2:
                        Console.WriteLine("Withdraw Money: ");
                        NB.CheckBalance(balance = balance - double.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("Thank you for using this program");
                        Running = false;
                        break;

                }
            }
        }
    }
}
