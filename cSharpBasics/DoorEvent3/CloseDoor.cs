using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent3
{
    class CloseDoor
    {
        public Access giveAccess;

        public CloseDoor(Access giveAccess)
        {
            this.giveAccess = giveAccess;
            giveAccess.AllowAccess += CloseDoorAccess;
        }

        public void CloseDoorAccess(object o, userDetails e)
        {
            Console.WriteLine("Close Door 3");
        }
    }
}
