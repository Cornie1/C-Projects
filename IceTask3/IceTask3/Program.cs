namespace IceTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHome home = new SmartHome();

            home.DeviceAdded += (msg) => Console.WriteLine(msg);

            bool Running = true;
            while (Running)
            {
                    Console.WriteLine("\n1:Add a device: " +
                                       "\n2:View the status of devices: " +
                                       "\n3:Run all devices: " +
                                       "\n4:Turn off al devices: " +
                                       "\n5:Exit: " +
                                       "\n-------------------------- ");

                    

                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            Console.WriteLine("Enter device type (1 = Light, 2 = Thermostat):");
                            int type = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter device name:");
                            string name = Console.ReadLine();

                            if (type == 1)
                            {
                                home.AddDevice(new Light { Name = name });
                            }
                            else if (type == 2)
                            {
                                home.AddDevice(new thermostat { Name = name });
                            }
                            break;
                        case 2:
                            Console.WriteLine("This is the list of devices");
                            home.ShowAllDevices();
                        break;
                        case 3:
                            home.RunAllDevices();
                            break;
                        case 4:
                            home.TurnOffAllDevices();
                            break;
                        case 5:
                            Console.WriteLine("Thank you for using this program");
                            Running = false;
                            break;
                        default:
                            Console.WriteLine("invalid selection");
                            break;
                    }
                
            }
        }
    }
}
