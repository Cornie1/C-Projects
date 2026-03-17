namespace revisionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StuentClass student = new StuentClass();

            Console.WriteLine("Welcome please enter your name: ");
            student.studentname = Console.ReadLine();

            Console.WriteLine("please enter what year you are in: ");
            student.studentYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter what degree you are doing: ");
            student.studentDegree = Console.ReadLine();

            string[] modules = new string[4];

            Console.WriteLine("Please enter the 4 modules you are taking:");

            for (int i = 0; i < modules.Length; i++)
            {
                Console.WriteLine("Module " + (i + 1)+":");
                modules[i] = Console.ReadLine();
            }
            Console.WriteLine(student.StudentInformation());

            for (int i = 0; i < modules.Length; i++) 
            {
                Console.WriteLine("Module " + (i + 1) + ":" + modules[i]);
            }

        }
    }
}
