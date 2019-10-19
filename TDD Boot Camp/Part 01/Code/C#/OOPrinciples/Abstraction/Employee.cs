using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Employee
    {
        public String Name { get; set; }
        public String Id { get; set; }
        public double Salary { get; set; }
        public String DepartmentName { get; set; }
        public Employee(String _name, String _id, double _salary, String _departmentName)
        {
            Name = _name;
            Id = _id;
            Salary = _salary;
            DepartmentName = _departmentName;
        }
    }
}
