using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Car
    {
        private Engine engine;
        public Car(Engine engine)
        {
            this.engine = engine;
        }

        public void StartEngine()
        {
            engine.Start();
        }


        public void ShutDownEngine()
        {
            engine.Start();
        }
    }
}
