namespace DesignPatterns.Creational.AbstractFactory.Products
{
    class RegularCar : ICar
    {
        public int NumberOfDoors { get; set; }
        public bool HasAirConditioning { get; set; }
        public string Type { get; }

        public RegularCar(int numberOfDoors, bool hasAirConditioning)
        {
            NumberOfDoors = numberOfDoors;
            HasAirConditioning = hasAirConditioning;
            Type = "Regular";
        }

        public void ApplyHandBrakes()
        {
            Console.WriteLine("Handbrake Applied!");
        }

        public int GetEngineCapacity()
        {
            return 2000;
        }

        public int GetMaxSpeed()
        {
            return 190;
        }

        public double GetMileage()
        {
            return 16;
        }

        public int GetServiceInterval()
        {
            return 12500;
        }
    }
}
