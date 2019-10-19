using System;
using System.Collections.Generic;
using System.Text;

namespace TellDoNotAsk.Good
{
    public class Tester
    {
        public Unit ConvertToCentiMeters()
        {
            Unit actual = new Unit(10, UnitType.MILIMETERS);
            return actual.ConvertTo(UnitType.CENTIMETERS);
        }
        public Unit ConvertToMeters()
        {
            Unit actual = new Unit(10, UnitType.CENTIMETERS);
            return actual.ConvertTo(UnitType.METERS);
        }
    }
}
