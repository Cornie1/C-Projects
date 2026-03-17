namespace String_manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UserName = "";
            string? UserSurname = null; //It doesnt need to have a string inputted into it as it can be left empty(null)
            var userPassword = "123";


            Console.WriteLine("please enter your name");
            UserName = Console.ReadLine();
            
            Console.WriteLine($"Welcome {UserName}");
            Console.WriteLine("The length of the name is: " + UserName.Length);
            Console.WriteLine("The name is uppercase is: " + UserName.ToUpper());
            Console.WriteLine("The name is lowercase is: " + UserName.ToLower());

            //Console.WriteLine($"The username is reversed {UserName.Reverse()}"); //Needs array idk why we did this cause yeah but okay

            if (UserName.Contains("an"))
            {
                Console.WriteLine("The name contains 'an': " + UserName.Replace("an", ""));
            }
            else
            {
                Console.WriteLine("No an was found");
            }

            Console.WriteLine("please enter your mark for test 1:");
            int mark1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter your mark for test 2:");
            int mark2 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter your mark for test 3:");
            int mark3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"The Marks for {UserName} are: \n Test 1 {mark1}: \n Test 2 {mark2}: \n Test 3 {mark3}:");

            if (mark1 <= 49)
            {
                Console.WriteLine("You failed test1");
            }
            else if (mark1 >= 50 && mark1 <= 74)
            {
                Console.WriteLine("You Passed test1");
            }
            else if (mark1 >=75)
            {
                Console.WriteLine("You passed test 1 with a distinction");
            }
        }
    }
}
