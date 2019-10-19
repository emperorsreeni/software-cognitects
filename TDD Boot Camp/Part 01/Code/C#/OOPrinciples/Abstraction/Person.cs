using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int GetAge()
        {
            return CalculateAge();
        }

        int CalculateAge()
        {
            double duration = (DateTime.Now - DateOfBirth).TotalSeconds;
            return (int)(duration / (60 * 60 * 24 * 365));
        }
    }
}
