using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6OOPGenericCollections
{
    internal class Employee
    {
        public string EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }
        public Employee(string id, string name, string gender, decimal salary)
        {
            EmployeeId = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{EmployeeId} - {Name} ({Gender}) earns {Salary} SEK";
        }
          
    }
}
