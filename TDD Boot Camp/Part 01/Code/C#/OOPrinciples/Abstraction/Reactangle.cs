using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Reactangle
    {
        public Size Size { get; set; }
        public Point Point { get; set; }
        public Reactangle(Point _point, Size _size)
        {
            Point = _point;
            Size = _size;
        }
    }
}
