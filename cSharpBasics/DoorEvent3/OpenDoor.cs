using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent3
{
    class OpenDoor
    {
        public Access giveAccess;

        public OpenDoor(Access giveAccess)
        {
            this.giveAccess = giveAccess;
            giveAccess.AllowAccess += OpenDoorAccess;
        }

        public void OpenDoorAccess(object o , userDetails e)
        {
            Console.WriteLine("Open Door 3 for " + e.empName);
        }
    }
}
