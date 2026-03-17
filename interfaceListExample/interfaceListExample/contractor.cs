using System;
using System.Collections.Generic;
using System.Text;

namespace interfaceListExample
{
    class contractor : ISalaryCalculator
    {
        public string name { get; set; }
        public int hoursWorked { get; set; }
        public double hourlyRate { get; set; }
        public contractor(string name, int hoursWorked, double hourlyRate)
        {
            this.name = name;
            this.hoursWorked = hoursWorked;
            this.hourlyRate = hourlyRate;
        }
        public double CalculateSalary()
        {
            return hoursWorked* hourlyRate;
        }
        public string GetEmployeeType()
        {
            return "Contractor";
        }
    }
}
