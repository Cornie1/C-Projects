using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace AnonymousMethods
{
    internal class Program
    {
        //delegate void MyDelegate(int x);
        public delegate int Operation(int a, int b);
        public delegate bool Filter(int number);
        static void Main(string[] args)
        {
            Operation add = delegate (int a, int b)
            {
                return a + b;
            };

            Operation multiply = delegate (int a, int b)
            {
                return a * b;
            };
            Console.WriteLine("Addition: " + add(5, 3));
            Console.WriteLine("Multiplication: " + multiply(5, 3));

            List<int> numbers = new List<int> { 10, 15, 20, 25, 30 };

            List<int> filtered = FilterNumbers(numbers, delegate (int n)
            {
                return n > 20;
            });

            Console.WriteLine("Number greater than 20:");

            foreach(var num in filtered) 
            {
                Console.WriteLine(num);
            }
            //MyDelegate del = delegate (int x)
            //{
            //Console.WriteLine("Value: " + x);
            //};
            //del(10);
        }
        public static List<int> FilterNumbers(List<int> list, Filter filter)
        {
            List<int> result = new List<int>();

            foreach(var item in list)
            {
                if (filter(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
