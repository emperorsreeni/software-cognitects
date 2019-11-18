using System;
using System.Collections.Generic;
using System.Text;

namespace TellDoNotAsk.Good
{
    public class Unit
    {
        private double _value { get; set; }
        private UnitType _unitType { get; set; }
        public Unit(double value, UnitType unitType)
        {
            _value = value;
            _unitType =  unitType;
        }

        public Unit ConvertTo(UnitType unitType)
        {
            //check the source unit type
            //convert to destination unit type

            //dummy return
            return new Unit(10, unitType);
        }
    }
}
