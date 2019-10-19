using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Point
    {
        private int X { get; set; }
        private int Y { get; set; }
        public void SetLocation(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }
    }
}
