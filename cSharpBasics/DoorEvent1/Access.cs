using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent1
{
    class Access
    {
        public delegate void GiveAccess();
        public event GiveAccess allowThePerson;
        public void DoorAccess()
        {
            allowThePerson?.Invoke();
        }

    }
}
