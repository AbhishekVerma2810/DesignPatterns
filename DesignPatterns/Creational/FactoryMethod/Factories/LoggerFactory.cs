using DesignPatterns.Creational.FactoryMethod.Products;

namespace DesignPatterns.Creational.FactoryMethod.Factories
{
    abstract class LoggerFactory
    {
        public abstract ILogger CreateLogger();
    }
}
