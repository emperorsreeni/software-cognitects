using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Point
    {
        private int x;
        private int y;
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public void SetLocation(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
