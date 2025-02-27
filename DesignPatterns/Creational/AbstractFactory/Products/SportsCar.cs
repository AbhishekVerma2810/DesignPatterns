namespace DesignPatterns.Creational.AbstractFactory.Products
{
    class SportsCar : ICar
    {
        public int NumberOfDoors { get; set; }
        public bool HasAirConditioning { get; set; }
        public string Type { get; }

        public SportsCar(int numberOfDoors, bool hasAirConditioning)
        {
            NumberOfDoors = numberOfDoors;
            HasAirConditioning = hasAirConditioning;
            Type = "Sports";
        }

        public void ApplyHandBrakes()
        {
            Console.WriteLine("Handbrake Applied!");
        }

        public int GetEngineCapacity()
        {
            return 4000;
        }

        public int GetMaxSpeed()
        {
            return 285;
        }

        public double GetMileage()
        {
            return 9;
        }

        public int GetServiceInterval()
        {
            return 8500;
        }
    }
}
