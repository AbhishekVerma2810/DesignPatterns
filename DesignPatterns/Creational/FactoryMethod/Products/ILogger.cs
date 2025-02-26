namespace DesignPatterns.Creational.FactoryMethod.Products
{
    //  This interface is must for implementing Factory Method DP
    interface ILogger
    {
        void Debug(string message);
        void Info(string message);
        void Warning(string message);
        void Error(string message, Exception exception);
    }
}
