using System;
using System.Collections.Generic;
using System.Text;

namespace StrechtSkills
{
    public class GPSDecorator : CarDecorator
    {
        public GPSDecorator(Car car) : base (car)
        {

        }
        public override decimal GetPrice()
        {
            return base.GetPrice() + 300;
        }

        public override string GetName()
        {
            return base.GetName() + " z GPSem";
        }

    }
}
