using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Finance
    {
        private readonly EmployeeSeparator employeeSeperator;

        public Finance(EmployeeSeparator employeeSeperator)
        {
            this.employeeSeperator = employeeSeperator;
            employeeSeperator.EmployeeSeparated += EmployeeSeperatedEventHandler;
        }

        public void EmployeeSeperatedEventHandler(object sender, EmployeeEventArgs e)
        {
            Console.WriteLine("Finance department: employee seperation process related to finance " + e.Name);
        }
    }
}
