using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class PartTimeEmployee: Employee
    {
        public decimal HourlyRate { get; set; }
        public decimal HoursWorked { get; set; }

        public PartTimeEmployee(int id, string name, decimal hourlyRate, decimal hoursWorked)
            :base(id, name, hourlyRate * hoursWorked)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }
        
       

        public override void GetDetails()
        {
            Console.WriteLine($"ID: {Id}\nName: {Name}\n" +
                $"Hourly Rate: {HourlyRate:C}\n" +
                $"Hours Worked: {HoursWorked}\n" +
                $"Total Pay: {HourlyRate * HoursWorked:C}");
        }
    }
}
