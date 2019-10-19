using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public class Car : Exhaustable
    {
        private Engine Engine { get; set; }
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
            Engine.Stop();
        }

        public void Exhaust()
        {
            //Do exhaust		
        }
    }
}
