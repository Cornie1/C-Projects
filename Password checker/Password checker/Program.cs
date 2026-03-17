using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Password_checker
{
    internal class Program
    {
        public static bool PasswordCorrection(string Password)
        {
            if (Password.Length < 10)
                return false;

                bool PLower = Password.Any(Char.IsLower);
                bool PUpper = Password.Any(Char.IsUpper);
                bool PDigit = Password.Any(Char.IsDigit);

                return PLower && PUpper && PDigit;

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your password");
            string Password = Console.ReadLine();

            if PasswordCorrection(Password))
                Console.WriteLine("Your password works");
            else
                Console.WriteLine("weak");
        }
    }

}
