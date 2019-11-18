using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Reactangle
    {
        public Size Size { get; set; }
        public Point Point { get; set; }
        public Reactangle(Point point, Size size)
        {
            Point = point;
            Size = size;
        }
    }
}
