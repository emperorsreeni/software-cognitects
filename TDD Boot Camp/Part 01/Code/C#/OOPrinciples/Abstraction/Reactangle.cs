using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Reactangle
    {
        private Size size;
        private Point point;
        public Reactangle(Point point, Size size)
        {
            this.point = point;
            this.size = size;
        }
        public Point GetPoint()
        {
            return point;
        }
        public Size GetSize()
        {
            return size;
        }
    }
}
