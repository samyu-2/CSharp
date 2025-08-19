using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class IT
    {
        private readonly EmployeeSeparator employeeSeparator;

        public IT(EmployeeSeparator employeeSeparator)
        {
            this.employeeSeparator = employeeSeparator;
            employeeSeparator.EmployeeSeparated += EmployeeSeperatedEventHandler;
        }

        public void EmployeeSeperatedEventHandler(object sender , EmployeeEventArgs e)
        {
            Console.WriteLine("IT department: Employee seperation process related to IT department " + e.Name );
        }
    }
}
