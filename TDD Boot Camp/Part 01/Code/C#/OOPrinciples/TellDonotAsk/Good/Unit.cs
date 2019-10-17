using System;
using System.Collections.Generic;
using System.Text;

namespace telldonotask.Good
{
    public class Unit
    {
        private double value;
        private UnitType unitType;
        public Unit(double value, UnitType unitType)
        {
            this.value = value;
            this.SetUnitType(unitType);
        }
        public double GetValue()
        {
            return value;
        }

        public void SetValue(double value)
        {
            this.value = value;
        }
        public UnitType GetUnitType()
        {
            return unitType;
        }
        public void SetUnitType(UnitType unitType)
        {
            this.unitType = unitType;
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
