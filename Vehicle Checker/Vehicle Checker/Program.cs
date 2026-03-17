namespace Vehicle_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Car information");
            Console.WriteLine("Enter your name,VehicleType, Colour of Vehicle, Amount of Wheels , Type of Fuel");
            VehicleClass VehicleType = new VehicleClass(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine());

            display(VehicleType);
        }
        static void display(VehicleClass VehicleType)
        {
            Console.WriteLine("Displaying student information: ");
            Console.WriteLine(VehicleType.display());

        }
    }
}
