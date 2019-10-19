using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Car
    {
        private Engine Engine;
        public Car(Engine _engine)
        {
            Engine = _engine;
        }

        public void StartEngine()
        {
            Engine.Start();
        }

        public void ShutDownEngine()
        {
            Engine.Start();
        }
    }
}
