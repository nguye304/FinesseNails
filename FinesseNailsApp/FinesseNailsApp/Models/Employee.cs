//this page will access a mysql database about the employees
//it will allow users to read about everyone
using System.Collections.Generic;

namespace FinesseNailsApp
{
    public class Employee
    {
        public string Name{get; set;}
        public int Age{ get; set; }

    }

    public class EmpRootObject
    {
        public List<Employee> Employees { get; set; }
    }
}