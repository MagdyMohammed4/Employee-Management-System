using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class FullTimeEmployee: Employee
    {
        public FullTimeEmployee(int id, string name, decimal salary):base(id, name, salary) { }
        

        public override void GetDetails()
        {
            Console.WriteLine($"ID: {Id}\nName: {Name}\nAnnual Salary: {Salary * 12:C}");
        }






    }
}
