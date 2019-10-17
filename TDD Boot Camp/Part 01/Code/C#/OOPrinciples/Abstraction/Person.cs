using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Person
    {
        public String firstName;
        public String lastName;
        public DateTime dateOfBirth;

        public int GetAge()
        {
            return CalculateAge();
        }

        int CalculateAge()
        {
            double duration = (DateTime.Now - dateOfBirth).TotalSeconds;
            return (int)(duration / (60 * 60 * 24 * 365));
        }
    }
}
