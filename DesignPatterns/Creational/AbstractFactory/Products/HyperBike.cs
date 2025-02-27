namespace DesignPatterns.Creational.AbstractFactory.Products
{
    class HyperBike : IBike
    {
        public bool HasKickStart { get; set; }
        public string Type { get; }

        public HyperBike(bool hasKickStart)
        {
            HasKickStart = hasKickStart;
            Type = "Hyper";
        }

        public void DoWheelie()
        {
            Console.WriteLine("SHITT :O");
        }

        public int GetEngineCapacity()
        {
            return 1200;
        }

        public int GetMaxSpeed()
        {
            return 320;
        }

        public double GetMileage()
        {
            return 11.5;
        }

        public int GetServiceInterval()
        {
            return 3000;
        }
    }
}
