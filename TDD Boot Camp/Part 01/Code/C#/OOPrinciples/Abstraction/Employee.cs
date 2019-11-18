using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public class Employee
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public double Salary { get; set; }
        public string DepartmentName { get; set; }
        public Employee(string name, string id, double salary, string departmentName)
        {
            Name = name;
            Id = id;
            Salary = salary;
            DepartmentName = departmentName;
        }
    }
}
