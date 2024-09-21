using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public abstract class Employee
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected decimal Salary { get; set; }


        protected Employee(int id, string name, decimal salary) 
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public virtual  void GetDetails()
        {
            Console.WriteLine($"ID: {Id}\nName: {Name}\nSalary: {Salary:C}");
        }

    }
}
