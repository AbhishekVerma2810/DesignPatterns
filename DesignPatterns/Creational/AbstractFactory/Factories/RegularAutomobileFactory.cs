using DesignPatterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    class RegularAutomobileFactory : IAutomobileFactory
    {
        public IBike CreateBike()
        {
            return new RegularBike(true);
        }

        public ICar CreateCar()
        {
            return new RegularCar(4, true);
        }
    }
}
