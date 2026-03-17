using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Activity_Test_Marks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Marks = new int[3];
            while (true)
            {
                Console.WriteLine("====== Welcome! Please Select an option !======");
                Console.WriteLine("Press 1 to Enter test Marks");
                Console.WriteLine("Press 2 View Test Marks");
                Console.WriteLine("Press 3 to Average Marks");
                Console.WriteLine("Press 4 to Exit");

                int Menu = int.Parse(Console.ReadLine());
                switch (Menu)
                {
                    case 1:
                        Console.WriteLine("Enter test Marks");
                        for (int i = 0; i < Marks.Length; i++)
                        {
                            Console.WriteLine("Marks " + (i + 1) + ": ");
                            Marks[i] = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 2:
                        Console.WriteLine("View Test Marks");

                        for (int i = Marks.Length - 1; i >= 0; i--)
                        {
                            Console.WriteLine(Marks[i]);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Work out Average");
                        int average = (Marks[0] + Marks[1] +Marks[2]/3);
                        Console.WriteLine(average);

                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
