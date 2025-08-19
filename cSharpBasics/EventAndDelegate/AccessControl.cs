using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    class AccessControl
    {
        public delegate void DoorAction();

        public event DoorAction DoorAccessed;

        public void TapCard()
        {
            Console.WriteLine("Access card tapped...");
            DoorAccessed?.Invoke();
        }

        public void openDoor()
        {
            Console.WriteLine("Door Open");
        }

        public void closeDoor()
        {
            Console.WriteLine("Door Close");
        }
    }
}
