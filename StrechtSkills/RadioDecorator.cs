using System;
using System.Collections.Generic;
using System.Text;

namespace StrechtSkills
{
    public class RadioDecorator : CarDecorator
    {
        public RadioDecorator(Car car) : base(car)
        {

        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + 200;
        }

        public override string GetName()
        {
            return base.GetName() + " z radiem";
        }
    }
}
