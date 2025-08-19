using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class EmployeeEventArgs : EventArgs
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
    }
    class EmployeeSeparator
    {
        //public delegate void EmployeeSeperatedEventHandler();

        public event EventHandler<EmployeeEventArgs> EmployeeSeparated;

        public void Seperate()
        {
            //if(EmployeeSeparated != null)
            //{
            //    EmployeeSeparated();
            //}

            EmployeeEventArgs employeeEventArgs = new EmployeeEventArgs { EmpId = 123, Name = "John" };

            EmployeeSeparated?.Invoke(this, employeeEventArgs);   //check if null, not null then method calls
        }
    }
}
