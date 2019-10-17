using System;
using System.Collections.Generic;
using System.Text;

namespace telldonotask.Bad
{
    public class Unit
    {
        private double value;
        public Unit(double value)
        {
            this.value = value;
        }
        public double GetValue()
        {
            return value;
        }

        public void GetValue(double value)
        {
            this.value = value;
        }
    }
}
