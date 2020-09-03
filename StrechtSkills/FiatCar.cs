using System;
using System.Collections.Generic;
using System.Text;

namespace StrechtSkills
{
    class FiatCar : Car
    {
        public override decimal GetPrice()
        {
            return 5000;
        }

        public override string GetName()
        {
            return "Fiat";
        }
    }
}
