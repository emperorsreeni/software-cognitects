using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Elan
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Elan()
        {
            FirstName = "Elan";
            LastName = "Sreenivasan";
            DateOfBirth = new DateTime(2018, 11, 13);
        }

        public int GetAge()
        {
            return CalculateAge();
        }

        public int CalculateAge()
        {
            double duration = (DateTime.Now - DateOfBirth).TotalSeconds;
            return (int)(duration / (60 * 60 * 24 * 365));
        }
    }
}
