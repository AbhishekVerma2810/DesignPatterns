using DesignPatterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    class SportsAutomobileFactory : IAutomobileFactory
    {
        public IBike CreateBike()
        {
            return new SportsBike(false);
        }

        public ICar CreateCar()
        {
            return new SportsCar(4, true);
        }
    }
}
