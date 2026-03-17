using System;

namespace Deligates
{
    //1. Declar a delegate
    public delegate int Operation(int a, int b);
    internal class Program
    {
        //2. Methods matching the delegate signature
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Multiply(int a, int b) 
        {
            return a * b; 
        }
        static void Main(string[] args)
        {
            //3. Crate a delegate instance
            Operation op;

            //Assign add method
            op = Add;
            Console.WriteLine("Add: " + op(5, 3));
            op = Multiply;
            Console.WriteLine("multiple: " + op(5, 3));

            op = Add;
            op += Multiply;

            Console.WriteLine("\nMultiecast deletage calls:");
            foreach(Operation del in op.GetInvocationList())
            {
                Console.WriteLine(del(4, 2));
            }
            Console.ReadLine();
        }
    }
}
