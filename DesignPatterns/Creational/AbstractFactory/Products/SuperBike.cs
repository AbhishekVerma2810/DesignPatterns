namespace DesignPatterns.Creational.AbstractFactory.Products
{
    class SuperBike : IBike
    {
        public bool HasKickStart { get; set; }
        public string Type { get; }

        public SuperBike(bool hasKickStart)
        {
            HasKickStart = hasKickStart;
            Type = "Super";
        }

        public void DoWheelie()
        {
            Console.WriteLine("Performing Wheelie!!!");
        }

        public int GetEngineCapacity()
        {
            return 1000;
        }

        public int GetMaxSpeed()
        {
            return 285;
        }

        public double GetMileage()
        {
            return 18.5;
        }

        public int GetServiceInterval()
        {
            return 4500;
        }
    }
}
