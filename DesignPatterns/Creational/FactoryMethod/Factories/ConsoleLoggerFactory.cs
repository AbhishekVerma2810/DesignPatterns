using DesignPatterns.Creational.FactoryMethod.Products;

namespace DesignPatterns.Creational.FactoryMethod.Factories
{
    class ConsoleLoggerFactory : LoggerFactory
    {
        public override ILogger CreateLogger()
        {
            return new ConsoleLogger();
        }
    }
}
