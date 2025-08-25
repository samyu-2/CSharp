using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Delegate
    {
        public delegate void MyDelegate(string message);

        public static void PrintMessage(string msg)
        {
            Console.WriteLine("Message: " + msg);
        }

        public static void Display()
        {
            MyDelegate myDelegate = new MyDelegate(PrintMessage);
            myDelegate("Hello Delegates");
        }
    }
    class Publisher
    {
        public delegate void Notify();
        public event Notify OnProcessControl;

        public void StartProcess()
        {
            Console.WriteLine("Process Started");

            if(OnProcessControl != null)
            {
                OnProcessControl();
            }
        }
    }

    class Subscriber
    {
        public void subscriber(Publisher publisher)
        {
            publisher.OnProcessControl += processCompleteHandler;
        }

        private void processCompleteHandler()
        {
            Console.WriteLine("Process Completed...Subscriber Notified");
        }
    }

    class Events
    {
        public static void Display()
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            subscriber.subscriber(publisher);
            publisher.StartProcess();
        }
    }
    //Delegates = function pointers (call methods dynamically).
    //Events = notification mechanism(publisher–subscriber).
    //Together, they enable loose coupling, reusability, and extensibility.
}
