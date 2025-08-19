using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeSeparator employeeSeperator = new EmployeeSeparator();
            Finance finance = new Finance(employeeSeperator);
            IT it = new IT(employeeSeperator);
            employeeSeperator.Seperate();
            Console.ReadKey();
        }
    }
}
