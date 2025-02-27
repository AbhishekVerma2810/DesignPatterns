using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Creational.AbstractFactory
{
    class Client
    {
        public void StartClient()
        {
            Dictionary<string, IAutomobileFactory> factories = new() 
            {
                { "regular", new RegularAutomobileFactory() },
                { "sports", new SportsAutomobileFactory() },
                { "super", new SuperAutomobileFactory() },
                { "hyper", new HyperAutomobileFactory() },
            };

            IAutomobileFactory factory = null;

            while (factory == null)
            {
                Console.Clear();
                Console.WriteLine("========== Automobile Setup ==========");
                Console.WriteLine("Choose a Automobile Type: \n  - Regular\n  - Sports\n  - Super\n  - Hyper");
                Console.Write("Enter your choice: ");

                string automobileType = Console.ReadLine()?.Trim().ToLower();

                if (factories.TryGetValue(automobileType, out factory))
                {
                    Console.WriteLine("\n Automobile Type selected successfully!\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Invalid choice! Please enter a valid automobile type.");
                    Console.ResetColor();
                    Console.WriteLine("\nPress any key to try again...");
                    Console.ReadKey();
                }

                ICar car = factory.CreateCar();
                IBike bike = factory.CreateBike();

                Console.WriteLine(GetCarDetails(car));
                Console.WriteLine(GetBikeDetails(bike));
            }
        }

        private string GetCarDetails(ICar car) =>
                    $"\n ===== Car Details =====\n" +
                    $" Type       : {car.Type}\n" +
                    $" Doors      : {car.NumberOfDoors}\n" +
                    $" Engine     : {car.GetEngineCapacity()} cc\n" +
                    $" Speed      : {car.GetMaxSpeed()} KM/H\n" +
                    $" Mileage    : {car.GetMileage()} KM/L\n" +
                    $" Service    : {car.GetServiceInterval()} KM\n" +
                    $"==========================\n";

        private string GetBikeDetails(IBike bike) =>
            $"\n  ===== Bike Details =====\n" +
            $" Type       : {bike.Type}\n" +
            $" KickStart  : {(bike.HasKickStart ? "Yes" : "No")}\n" +
            $" Engine     : {bike.GetEngineCapacity()} cc\n" +
            $" Speed      : {bike.GetMaxSpeed()} KM/H\n" +
            $" Mileage    : {bike.GetMileage()} KM/L\n" +
            $" Service    : {bike.GetServiceInterval()} KM\n" +
            $"============================\n";
    }
}