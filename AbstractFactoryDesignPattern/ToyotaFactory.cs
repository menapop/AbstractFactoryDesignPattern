using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    public class ToyotaFactory : ICarFactory
    {

        private int price;
        private int Tax;
        public ToyotaFactory(int price, int Tax)
        {
            this.price = price;
            this.Tax = Tax;
        }
        public int CaculatePrice()
        {
            return price + ( Tax*200);
        }
    }
}
