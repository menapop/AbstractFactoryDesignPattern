using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class HondaFactory : ICarFactory
    {
        private int price;
        public HondaFactory(int price) => this.price = price;

        public int CaculatePrice()
        {
            return this.price * 2; 
        }

    }
}
