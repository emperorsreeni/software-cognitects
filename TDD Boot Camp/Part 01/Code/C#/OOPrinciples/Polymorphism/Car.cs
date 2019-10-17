using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Car : Exhaustable
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
            engine.Stop();
        }

        public void Exhaust()
        {
            //Do exhaust		
        }
    }
}
