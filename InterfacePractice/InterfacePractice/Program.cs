
using System.Diagnostics.Contracts;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPerson> person = new List<IPerson>();

            person.Add(new Student("Bob", 12, 8));
            person.Add(new Teacher("Charlie",45, "Maths"));

            foreach (var p in person)
            {
                Console.WriteLine($"Person Type : {p.GetPersonType()}");
                Console.WriteLine($"Details: {p.RDetails()}");
                Console.WriteLine("----------------------------------");
            }
            Console.ReadLine();
        }
    }
}
