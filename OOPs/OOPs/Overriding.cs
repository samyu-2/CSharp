using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Vehicle1
    {
        public virtual void Drive()
        {
            Console.WriteLine("Driving vehicle...");
        }
    }

    class Car1 : Vehicle1
    {
        public override void Drive()
        {
            //base.Drive();
            Console.WriteLine("Driving car...");
        }
    }
    class Overriding
    {
        //Different classes, same method signature
        //Parent method -> marked virtual.  Child method -> marked override
        //Runtime polymorphism (decided at runtime).

        public static void Display()
        {
            Car1 car = new Car1();
            Vehicle1 v1 = new Vehicle1();
            Vehicle1 v2 = new Car1();

            car.Drive();
            v1.Drive();    // Driving a vehicle...
            v2.Drive();    // Driving a vehicle...
        }
    }
}
