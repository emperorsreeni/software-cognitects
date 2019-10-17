using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Address
    {

        private String street;
        private String city;
        private String zip;

        public String GetStreet()
        {
            return street;
        }

        public void SetStreet(String street)
        {
            this.street = street;
        }

        public String GetCity()
        {
            return city;
        }

        public void SetCity(String city)
        {
            this.city = city;
        }

        public String GetZip()
        {
            return zip;
        }

        public void SetZip(String zip)
        {
            this.zip = zip;
        }
    }
}
