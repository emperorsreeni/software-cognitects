using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Department
    {
        private String id;
        private String name;
        public String GetName()
        {
            return name;
        }
        public void SetName(String name)
        {
            this.name = name;
        }
        public String GetId()
        {
            return id;
        }
        public void SetId(String id)
        {
            this.id = id;
        }
    }
}
