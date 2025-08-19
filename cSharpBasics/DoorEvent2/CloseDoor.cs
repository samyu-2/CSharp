using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent2
{
    class CloseDoor
    {
        public Access giveAccess;
        public CloseDoor(Access giveAccess)
        {
            this.giveAccess = giveAccess;
            giveAccess.AllowThePerson += CloseDoorAccess;
        }

        public void CloseDoorAccess(object o, EventArgs e)
        {
            Console.WriteLine("Close door 2");
        }
    }
}
