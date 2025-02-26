using DesignPatterns.Creational.FactoryMethod.Products;

namespace DesignPatterns.Creational.FactoryMethod.Factories
{
    class FileLoggerFactory : LoggerFactory
    {
        public override ILogger CreateLogger()
        {
            return new FileLogger();
        }
    }
}
