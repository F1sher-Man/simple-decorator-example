using System;
using System.Collections.Generic;
using System.Text;

namespace StrechtSkills
{
    public class FordCar : Car
    {
        public override decimal GetPrice()
        {
            return 10000;
        }

        public override string GetName()
        {
            return "Ford";
        }
    }
}
