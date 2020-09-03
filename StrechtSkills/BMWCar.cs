using System;
using System.Collections.Generic;
using System.Text;

namespace StrechtSkills
{
    class BMWCar : Car
    {
        public override decimal GetPrice()
        {
            return 25000;
        }

        public override string GetName()
        {
            return "BMW";
        }
    }
}
