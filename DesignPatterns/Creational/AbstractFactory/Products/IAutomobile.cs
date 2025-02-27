namespace DesignPatterns.Creational.AbstractFactory.Products
{
    interface IAutomobile
    {
        string Type { get; }
        int GetServiceInterval();
        int GetEngineCapacity();
        int GetMaxSpeed();
        double GetMileage();
    }
}
