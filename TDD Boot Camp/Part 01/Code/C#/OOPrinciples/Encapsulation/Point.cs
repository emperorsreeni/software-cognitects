using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void SetLocation(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
