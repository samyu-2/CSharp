using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorEvent3
{
    class userDetails : EventArgs
    {
        public string empName { get; set; }
        public int empId { get; set; }
    }
class Access
    {
        
        public EventHandler<userDetails> AllowAccess;

        public void GiveAccess()
        {
            userDetails details = new userDetails { empName = "Sam", empId = 123 };
            AllowAccess?.Invoke(this, details);
        }
    }
}
