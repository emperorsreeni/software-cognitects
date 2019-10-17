using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Iniyan
    {
        public String firstName;
        public String lastName;
        public DateTime dateOfBirth;

        public Iniyan()
        {
            this.firstName = "Iniyan";
            this.lastName = "Sreenivasan";
            this.dateOfBirth = new DateTime(2015, 11, 13);
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
