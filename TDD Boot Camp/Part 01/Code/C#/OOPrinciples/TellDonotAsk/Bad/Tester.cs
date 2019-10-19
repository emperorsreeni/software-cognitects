using System;
using System.Collections.Generic;
using System.Text;

namespace TellDoNotAsk.Bad
{
    public class Tester
    {
        public Unit ConvertToCentiMeters()
        {
            Unit actual = new Unit(10);            
            double convertedValue = actual.Value / 100;
            Unit converted = new Unit(convertedValue);
            return converted;
        }
        public Unit ConvertToMeters()
        {
            Unit actual = new Unit(10);            
            double convertedValue = actual.Value / 10000;
            Unit converted = new Unit(convertedValue);
            return converted;
        }
    }
}
