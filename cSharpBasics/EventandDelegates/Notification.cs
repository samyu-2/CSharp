using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventandDelegates
{
    class Notification
    {
        public void SendNotification(object sender , userdetails e)
        {
            Console.WriteLine($"[Notification] Welcome , {e.EmpName}! You may enter.");
        }
    }
}
