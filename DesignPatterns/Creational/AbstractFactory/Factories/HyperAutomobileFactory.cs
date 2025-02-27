using DesignPatterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    class HyperAutomobileFactory : IAutomobileFactory
    {
        public IBike CreateBike()
        {
            return new HyperBike(false);
        }

        public ICar CreateCar()
        {
            return new HyperCar(1, true);
        }
    }
}
