using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventandDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscribe = new Subscriber();
            Notification notification = new Notification();


            publisher.ProcessCompleted += subscribe.ShowMessage;
            publisher.StartProcess("Samyu",123);
            Console.ReadLine();
        }
    }
}
