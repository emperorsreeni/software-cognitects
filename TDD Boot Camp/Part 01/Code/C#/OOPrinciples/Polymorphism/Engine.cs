using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public abstract class Engine
    {
        public bool isRunning;
        public void Start()
        {
            this.isRunning = true;
        }
        public void Stop()
        {
            this.isRunning = false;
        }
    }
}
