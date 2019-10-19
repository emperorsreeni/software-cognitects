using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public abstract class Engine
    {
        public bool IsRunning { get; set; }
        public void Start()
        {
            IsRunning = true;
        }
        public void Stop()
        {
            IsRunning = false;
        }
    }
}
