namespace DesignPatterns.Creational.AbstractFactory.Products
{
    class SportsBike : IBike
    {
        public bool HasKickStart { get; set; }
        public string Type { get; }

        public SportsBike(bool hasKickStart)
        {
            HasKickStart = hasKickStart;
            Type = "Sports";
        }

        public void DoWheelie()
        {
            Console.WriteLine("Performing Wheelie!!!");
        }

        public int GetEngineCapacity()
        {
            return 600;
        }

        public int GetMaxSpeed()
        {
            return 200;
        }

        public double GetMileage()
        {
            return 27.5;
        }

        public int GetServiceInterval()
        {
            return 6000;
        }
    }
}
