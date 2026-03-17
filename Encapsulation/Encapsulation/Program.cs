using System.ComponentModel.DataAnnotations;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonClass studentOne = new PersonClass("bob", "alan", 30, "Art");

            PersonClass studentTwo = new PersonClass();

            studentTwo.name = "alice";

            display(studentOne);

            Console.ReadLine();
        }

        static void display(PersonClass studentOne)
        {
            Console.WriteLine("Displaying student information: ");
            Console.WriteLine(studentOne.display());

        }
    }
}
