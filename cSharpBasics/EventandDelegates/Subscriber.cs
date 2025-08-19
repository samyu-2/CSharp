using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventandDelegates
{
    class Subscriber
    {
        public void LogAccess(object sender , userdetails e)
        {
            Console.WriteLine($"[Security Log] Access Granted: {e.EmpName} (ID: {e.EmpId})");
        }
    }
}
