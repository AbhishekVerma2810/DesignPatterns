namespace DesignPatterns.Creational.AbstractFactory.Products
{
    interface IBike : IAutomobile
    {
        bool HasKickStart { get; set; }
        void DoWheelie();
    }
}
