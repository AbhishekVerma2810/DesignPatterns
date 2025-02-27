using DesignPatterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    class SuperAutomobileFactory : IAutomobileFactory
    {
        public IBike CreateBike()
        {
            return new SuperBike(false);
        }

        public ICar CreateCar()
        {
            return new SuperCar(2, true);
        }
    }
}
