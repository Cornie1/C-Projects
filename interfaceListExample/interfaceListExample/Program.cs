namespace interfaceListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ISalaryCalculator> employees = new List<ISalaryCalculator>();

            employees.Add(new fullTimeEmployee("Alice", 5000));
            employees.Add(new contractor("Bob", 120, 40));
            employees.Add(new contractor("Charlie", 100, 35.5));

            foreach (var employee in employees) 
            {
                Console.WriteLine($"Type: {employee.GetEmployeeType()}");
                Console.WriteLine($"Salary: {employee.CalculateSalary()}");
                Console.WriteLine("----------------------------------");
            }
            Console.ReadLine();

        }
    }
}
