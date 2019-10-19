using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Iniyan
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Iniyan()
        {
            FirstName = "Iniyan";
            LastName = "Sreenivasan";
            DateOfBirth = new DateTime(2015, 11, 13);
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
