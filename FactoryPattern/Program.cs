

namespace FactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What type of vehicle would you like to build?");
            string userInput = Console.ReadLine();

            VehicleFactory factory = new VehicleFactory();
            IVehicle myVehicle = VehicleFactory.CreateVehicle(userInput);

            myVehicle.Drive();

            Console.WriteLine("Would you like to build another vehicle?");
            userInput = Console.ReadLine();


        }
    }
}
