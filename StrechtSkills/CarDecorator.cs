using System;
using System.Collections.Generic;
using System.Text;

namespace StrechtSkills
{
    public abstract class CarDecorator : Car
    {
        protected Car _car;

        public CarDecorator(Car car)
        {
            _car = car;
        }

        public override decimal GetPrice()
        {
            return _car.GetPrice();
        }

        public override string GetName()
        {
            return _car.GetName();
        }
    }
}
