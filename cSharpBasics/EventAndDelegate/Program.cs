using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessControl access = new AccessControl();
            

            access.DoorAccessed += access.openDoor;
            access.DoorAccessed += access.closeDoor;
            access.TapCard();

            Console.ReadLine();
        }
    }
}
