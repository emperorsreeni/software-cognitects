using System;
using System.Collections.Generic;
using System.Text;

namespace telldonotask.Bad
{
    public class Tester
    {
        public Unit ConvertToCentiMeters()
        {
            Unit actual = new Unit(10);
            double value = actual.GetValue();
            double convertedValue = value / 100;
            Unit converted = new Unit(convertedValue);
            return converted;
        }
        public Unit ConvertToMeters()
        {
            Unit actual = new Unit(10);
            double value = actual.GetValue();
            double convertedValue = value / 10000;
            Unit converted = new Unit(convertedValue);
            return converted;
        }
    }
}
