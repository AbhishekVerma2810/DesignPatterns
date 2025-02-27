namespace DesignPatterns.Creational.AbstractFactory.Products
{
    class HyperCar : ICar
    {
        public int NumberOfDoors { get; set; }
        public bool HasAirConditioning { get; set; }
        public string Type { get; }

        public HyperCar(int numberOfDoors, bool hasAirConditioning)
        {
            NumberOfDoors = numberOfDoors;
            HasAirConditioning = hasAirConditioning;
            Type = "Hyper";
        }

        public void ApplyHandBrakes()
        {
            Console.WriteLine("Handbrake Applied!");
        }

        public int GetEngineCapacity()
        {
            return 6500;
        }

        public int GetMaxSpeed()
        {
            return 400;
        }

        public double GetMileage()
        {
            return 3.5;
        }

        public int GetServiceInterval()
        {
            return 4000;
        }
    }
}
