namespace DesignPatterns.Creational.AbstractFactory.Products
{
    class RegularBike : IBike
    {
        public bool HasKickStart { get; set; }
        public string Type { get; }

        public RegularBike(bool hasKickStart)
        {
            HasKickStart = hasKickStart;
            Type = "Regular";
        }

        public void DoWheelie()
        {
            Console.WriteLine("Unable To Perform :(");
        }

        public int GetEngineCapacity()
        {
            return 175;
        }

        public int GetMaxSpeed()
        {
            return 105;
        }

        public double GetMileage()
        {
            return 55;
        }

        public int GetServiceInterval()
        {
            return 7500;
        }
    }
}
