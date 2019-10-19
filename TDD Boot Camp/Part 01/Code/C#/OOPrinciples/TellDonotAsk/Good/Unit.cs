using System;
using System.Collections.Generic;
using System.Text;

namespace TellDoNotAsk.Good
{
    public class Unit
    {
        private double Value { get; set; }
        private UnitType UnitType { get; set; }
        public Unit(double _value, UnitType _unitType)
        {
            Value = _value;
            UnitType =  _unitType;
        }

        public Unit ConvertTo(UnitType _unitType)
        {
            //check the source unit type
            //convert to destination unit type

            //dummy return
            return new Unit(10, _unitType);
        }
    }
}
