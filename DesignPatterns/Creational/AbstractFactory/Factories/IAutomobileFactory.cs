using DesignPatterns.Creational.AbstractFactory.Products;
using System;
using System.Linq;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    interface IAutomobileFactory
    {
        IBike CreateBike();
        ICar CreateCar();
    }
}
