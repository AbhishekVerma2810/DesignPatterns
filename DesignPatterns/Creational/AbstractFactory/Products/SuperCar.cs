namespace DesignPatterns.Creational.AbstractFactory.Products
{
    class SuperCar : ICar
    {
        public int NumberOfDoors { get; set; }
        public bool HasAirConditioning { get; set; }
        public string Type { get; }

        public SuperCar(int numberOfDoors, bool hasAirConditioning)
        {
            NumberOfDoors = numberOfDoors;
            HasAirConditioning = hasAirConditioning;
            Type = "Super";
        }

        public void ApplyHandBrakes()
        {
            Console.WriteLine("Handbrake Applied!");
        }

        public int GetEngineCapacity()
        {
            return 5000;
        }

        public int GetMaxSpeed()
        {
            return 360;
        }

        public double GetMileage()
        {
            return 6;
        }

        public int GetServiceInterval()
        {
            return 6000;
        }
    }
}
