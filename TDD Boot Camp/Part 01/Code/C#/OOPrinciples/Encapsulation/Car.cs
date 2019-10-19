using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Car
    {
        private Engine _engine;
        public Car(Engine engine)
        {
            _engine = engine;
        }

        public void StartEngine()
        {
            _engine.Start();
        }

        public void ShutDownEngine()
        {
            _engine.Start();
        }
    }
}
