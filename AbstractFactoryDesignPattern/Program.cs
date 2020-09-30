using System;

namespace AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarAbstractFactory carAbstractFactory = new CarAbstractFactory(20000);

            ICarFactory Honda = carAbstractFactory.CreateHonda();

            ICarFactory Toyota = carAbstractFactory.CreateToyota();

            Console.WriteLine(Honda.GetType());

            Console.WriteLine(Toyota.GetType());
        }
    }
}
