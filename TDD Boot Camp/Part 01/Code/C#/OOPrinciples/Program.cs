using Abstraction;
using Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TellDoNotAsk.Good;


namespace OOPrinciples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "Abc",
                LastName = "Xyz",
                DateOfBirth = new DateTime(1992, 11, 16)
            };
            Console.WriteLine("Age is {0}", person.GetAge());            

            
            //Static Polymorphism
            DieselEngine dieselEngine = new DieselEngine();
            dieselEngine.Start();

            //Dynamic Polymorphism
            Engine engine = new PetrolEngine();
            engine.Start();

            Exhaustable exhaustable = new Car(engine);
            exhaustable.Exhaust();

            exhaustable = new PowerGenerator();
            exhaustable.Exhaust();
        }        
    }
}
