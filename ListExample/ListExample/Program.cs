using System;
using System.Collections;
using System.Collections.Generic;
namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Non-generic list (ArrayList)
            ArrayList nonGeneric = new ArrayList();

            nonGeneric.Add("Alice");
            nonGeneric.Add(25);
            nonGeneric.Add(3.14);
            nonGeneric.Add(true);

            Console.WriteLine("Non-generic Arraylist contents");

            //for (int i = 0; i < nonGeneric.Count; i++) { }

            foreach(object item in nonGeneric)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Generic List(List<T>)

            List<string> generic = new List<string>();

            generic.Add("Bob");
            generic.Add("Charlie");
            generic.Add("Diana");

            Console.WriteLine("Generic List<string> contents: ");

            foreach(string name in generic)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            Console.WriteLine($"First item within the generic list: {generic[0]}");
            generic.Remove("Charlie");

            Console.WriteLine("\nAfteer removing charlie");

            foreach (string name in generic)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\n Press any key to exit... ");
            Console.ReadKey();


        }
    }
}
