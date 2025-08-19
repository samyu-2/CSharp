using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent2
{
    class Access
    {
        public EventHandler<EventArgs> AllowThePerson;

        public void DoorAccess()
        {
            AllowThePerson?.Invoke(this,null);
        }
    }
}
