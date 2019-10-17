using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Employee
    {
        private String name;
        private String id;
        private double salary;
        private String departmentName;
        public Employee(String name, String id, double salary, String departmentName)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
            this.departmentName = departmentName;
        }
        public String GetName()
        {
            return name;
        }
        public String GetId()
        {
            return id;
        }
        public Double GetSalary()
        {
            return salary;
        }
        public String GetDepartment()
        {
            return departmentName;
        }
    }
}
