using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Delegate_Activity
{
    public delegate int Operation(int a);
    internal class Program
    {
        //2. Methods matching the delegate signature
        public static int Square(int a)
        {
            return a*a;
        }
        public static int Double(int a)
        {
            return a * 2;
        }
        public static int Tripple(int a)
        {
            return a * 3;
        }
        static void Main(string[] args)
        {
            bool Running = true;
            Operation op;
            while (Running)
            {
                try
                {
                    Console.WriteLine("\n1: Square your number: " +
                                       "\n2: Double your number: " +
                                       "\n3: Tripple your number:" +
                                       "\n4: Exit the Program:" +
                                       "\n-------------------------- ");

                    int Userinput = int.Parse(Console.ReadLine());

                    switch (Userinput)
                    {
                        case 1:
                            Console.WriteLine("Square your Number: ");
                            op = Square;
                            Console.WriteLine("Square: " + op(int.Parse(Console.ReadLine())));
                            break;
                        case 2:
                            Console.WriteLine("Double your number: ");
                            op = Double;
                            Console.WriteLine("Double: " + op(int.Parse(Console.ReadLine())));
                            break;
                        case 3:
                            Console.WriteLine("Tripple your Number");
                            op = Tripple;
                            Console.WriteLine("Tripple: " + op(int.Parse(Console.ReadLine())));
                            break;
                        case 4:
                            Console.WriteLine("Thank you for using this program");
                            Running = false;
                            break;
                        default:
                            Console.WriteLine("invalid selection");
                            break;
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input");
                }
            } 
        }
    }
}