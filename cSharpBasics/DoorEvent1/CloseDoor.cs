using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent1
{
    class CloseDoor
    {
        public Access GiveAccess;

        public CloseDoor(Access GiveAccess)
        {
            this.GiveAccess = GiveAccess;
            GiveAccess.allowThePerson += closeDoorAccess;
        }

        public void closeDoorAccess()
        {
            Console.WriteLine("Close door");
        }
    }
}
