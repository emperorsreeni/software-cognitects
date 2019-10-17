using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Elan
    {
        public String firstName;
        public String lastName;
        public DateTime dateOfBirth;

        public Elan()
        {
            this.firstName = "Elan";
            this.lastName = "Sreenivasan";
            this.dateOfBirth = new DateTime(2018, 11, 13);
        }

        public int GetAge()
        {
            return CalculateAge();
        }

        public int CalculateAge()
        {
            double duration = (DateTime.Now - dateOfBirth).TotalSeconds;
            return (int)(duration / (60 * 60 * 24 * 365));
        }
    }
}
