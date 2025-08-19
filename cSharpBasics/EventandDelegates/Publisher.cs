using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventandDelegates
{
    class userdetails : EventArgs
    {
        public string EmpName { get; set; }
        public int EmpId { get; set; }
    }

    class Publisher
    {
        //public delegate void NotifyHandler(string message);

        //public event NotifyHandler ProcessCompleted;

        public event EventHandler<userdetails> AccessGranted;

        public void TriggerAccess(string name , int id)
        {
            OnAccessGranted(new userdetails { EmpName = name, EmpId = id });
        }

        public void GiveAccess(string name , int id)
        {
            Console.WriteLine("Checking access for " + name);
            System.Threading.Thread.Sleep(1000);
            OnAccessGranted(new userdetails { EmpName = name, EmpId = id });
        }

        protected virtual void OnAccessGranted(userdetails details)
        {
            AccessGranted?.Invoke(this , details);
        }
    }
}
