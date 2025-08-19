using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent1
{
    class OpenDoor
    {
        public Access GiveAccess;
        public OpenDoor(Access GiveAccess)
        {
            this.GiveAccess = GiveAccess;
            GiveAccess.allowThePerson += openDoorAccess;
        }

        public void openDoorAccess()
        {
            Console.WriteLine("Door Opened");
        }
    }
}
