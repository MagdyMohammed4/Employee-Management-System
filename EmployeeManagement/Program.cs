using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee emp1 = new FullTimeEmployee(1,"Ali",5000);
            emp1.GetDetails();

            Console.WriteLine("-------------------------------------");

            PartTimeEmployee emp2 = new PartTimeEmployee(2,"Mohammed",50,40);
            emp2.GetDetails();

        }
    }
}
