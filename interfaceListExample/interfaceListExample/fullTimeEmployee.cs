using System;
using System.Collections.Generic;
using System.Text;

namespace interfaceListExample
{
    class fullTimeEmployee : ISalaryCalculator
    {
        public string name { get; set; }
        public double monthlySalary { get; set; }
        public fullTimeEmployee(string name, double monthlySalary)
        {
            this.name = name;
            this.monthlySalary = monthlySalary;
        }
        public double CalculateSalary()
        {
            return monthlySalary;
        }

        public string GetEmployeeType()
        {
            return "Full Time Employee";
        }

    }
}
