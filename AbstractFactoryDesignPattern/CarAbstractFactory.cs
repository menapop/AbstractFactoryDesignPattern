using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class CarAbstractFactory
    {
        private int Tax = 10000;
        private int price;
        public CarAbstractFactory(int price)
        {
            this.price = price;
        }
        public ICarFactory CreateHonda()
        {
            return new HondaFactory(price);
        }
        public ICarFactory CreateToyota()
        {
            return new ToyotaFactory(price, Tax);
        }

    }
}
