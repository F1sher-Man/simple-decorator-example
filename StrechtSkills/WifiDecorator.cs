using System;
using System.Collections.Generic;
using System.Text;

namespace StrechtSkills
{
    public class WifiDecorator : CarDecorator
    {
        public WifiDecorator(Car car) : base(car)
        {

        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + 500;
        }

        public override string GetName()
        {
            return base.GetName() + " z WiFi";
        }
    }
}
