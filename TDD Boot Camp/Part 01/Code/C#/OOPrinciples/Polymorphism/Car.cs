using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Car : Exhaustable
    {
        private Engine _engine { get; set; }
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
            _engine.Stop();
        }

        public void Exhaust()
        {
            //Do exhaust		
        }
    }
}
