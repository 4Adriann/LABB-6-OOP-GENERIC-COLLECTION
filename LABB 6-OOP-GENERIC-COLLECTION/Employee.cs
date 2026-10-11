using System;
using System.Collections.Generic;
using System.Text;

namespace LABB_6_OOP_GENERIC_COLLECTION
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Id { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, string gender, int id, decimal salary)
        {
            Name = name;
            Gender = gender;
            Id = id;
            Salary = salary;
        }
    }
}
