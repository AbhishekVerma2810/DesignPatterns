namespace DesignPatterns.Creational.AbstractFactory.Products
{
    interface ICar : IAutomobile
    {
        int NumberOfDoors { get; set; }
        bool HasAirConditioning { get; set; }
        void ApplyHandBrakes();
    }
}
