
namespace switch_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 2;

            switch (number)
            {
                case 1:
                    Console.WriteLine("you hav eselected number one");
                    break;
                case 2:
                    Console.WriteLine("you have selected number two");
                    break;
                case 3:
                    Console.WriteLine("You have selected number three");
                    break;
                default:
                    Console.WriteLine("invalid selection");
                    break;
            }
            string[] names = new string[5];
            string[] Surnames = { "john", "jane" , "dow"};

            Console.WriteLine("Enter names");

            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Name " + (i + 1) + ": ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("\n---Names in UPPERCASE---");
            for (int i = 0; i < Surnames.Length; i++) 
            {
                Console.WriteLine(names[i].ToUpper());
            }
            Console.WriteLine("\n---Names in reverse---");
            
            for (int i = names.Length - 1; i >= 0; i--) 
            {
                Console.WriteLine(names[i]);
            }

            for (int i = 0;i < names.Length; i++)
            {
                Console.WriteLine(names[i] + "has" + names[i].Length  + "characters");
            }

            Console.WriteLine("\n Press any key to exit");
            Console.ReadKey();

        }
    }
}
