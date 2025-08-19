using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent1
{
    class Program
    {
        static void Main(string[] args)
        {
            Access access = new Access();
            OpenDoor open = new OpenDoor(access);
            CloseDoor close = new CloseDoor(access);

            access.DoorAccess();
            Console.ReadLine();
        }
    }
}
