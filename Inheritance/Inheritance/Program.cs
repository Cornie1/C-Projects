namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mammalClass mammal = new mammalClass();
            mammal.name = "Dog";
            mammal.numOflegs = 4;
            mammal.tail = "Has tail";
            mammal.diet = "omnivore";
            mammal.furType = "Short fur";

            reptileClass reptile = new reptileClass();
            reptile.name = "Crocodile";
            reptile.numOflegs = 4;
            reptile.tail = "has a tail";
            reptile.diet = "Carnivore";
            reptile.scales = "Rough Scales";

            DisplayInfo(mammal);
            DisplayInfo(reptile);
        }

        static void DisplayInfo(AnimalClass animal)
        {
            Console.WriteLine("Displaying the data for.... ");
            Console.WriteLine(animal.DisplayInfo());
        }
    }
}
