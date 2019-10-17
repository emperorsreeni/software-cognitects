using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
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
