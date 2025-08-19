using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent2
{
    class OpenDoor
    {
        public Access giveAccess;

        public OpenDoor(Access giveAccess)
        {
            this.giveAccess = giveAccess;
            giveAccess.AllowThePerson += OpenDoorAccess;
        }

        public void OpenDoorAccess(object o , EventArgs e)
        {
            Console.WriteLine("Open Door 2");
        }
    }
}
