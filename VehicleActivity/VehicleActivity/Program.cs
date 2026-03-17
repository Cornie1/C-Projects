namespace VehicleActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.brand = "mercedes";
            car.numOfWheels = 4;
            car.colour = "black";
            car.FuelType = "unleaded";
            car.DoorAmount = 4;

            Truck trc = new Truck();
            trc.brand = "mercedes";
            trc.numOfWheels = 8;
            trc.colour = "black";
            trc.FuelType = "diesel";
            trc.loadcapacity = 3000;
            
            MotorBike mtr = new MotorBike();
            mtr.brand = "Honda";
            mtr.numOfWheels = 2;
            mtr.colour = "black";
            mtr.FuelType = "unleaded";
            mtr.HasSideCar = "Yes";


            DisplayInfo(car);
            DisplayInfo(trc);
            DisplayInfo(mtr);
        }

        static void DisplayInfo(VehicleClass vhc)
        {
            Console.WriteLine("Displaying the data for.... ");
            Console.WriteLine(vhc.DisplayInfo());
        }
    }
}
