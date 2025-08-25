using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Bank
    {
        public void bank()
        {
            Console.WriteLine("Welcome to bank");
        }
    }
    class Account : Bank   //single Inheritance  --  One base class and one derived class.
    {
        public void account()
        {
            Console.WriteLine("Your Account!");
        }
    }
    class SavingsAccount : Account  //multilevel Inheritance  --  Derived class acts as a base for another class.
    {
        public void savingAccount()
        {
            Console.WriteLine("Account type: Savings");
        }
    }

    class SalaryAccount : Account  //Hierarchical Inheritance  --  Multiple classes inherit from the same base class.
    {
        public void salaryAccount()
        {
            Console.WriteLine("Account type: Salary");
        }
    }

    interface IRemoteControls
    {
        void turnOn();
        void turnOff();
        void changeChannel();
    }

    class Television : IRemoteControls  //Multiple Inheritance - Interfaces
    {
        public void turnOn()
        {
            Console.WriteLine("Turn on TV");
        }
        public void turnOff()
        {
            Console.WriteLine("Turn Off TV");
        }
        public void changeChannel()
        {
            Console.WriteLine("Channel Changed");
        }   
    }

    class AC : IRemoteControls
    {
        public void turnOn()
        {
            Console.WriteLine("Turn on AC");
        }
        public void turnOff()
        {
            Console.WriteLine("Turn Off AC");
        }
        public void changeChannel()
        {
            Console.WriteLine("AC mode Changed");
        }
    }
    class TypesOfInheritance
    {
        public static void typesOfInheritanceDisplay()
        {
            Account acc = new Account();
            Console.WriteLine("Single Level Inheritance! ");
            acc.bank();
            acc.account();
            //acc.savingAccount();  --> parent can't use child methods
            Console.WriteLine();

            SavingsAccount sa = new SavingsAccount();
            Console.WriteLine("Multi Level Inheritance! ");
            sa.bank();
            sa.account();
            sa.savingAccount();
            Console.WriteLine();

            //Account sa1 = new SavingsAccount();
            //sa1.account();
            //sa1.savingAccount();  --  because Account reference doesn't know about savingAccount

            SalaryAccount salaryAccount = new SalaryAccount();
            Console.WriteLine("Hierarchical Inheritance");
            salaryAccount.bank();
            salaryAccount.account();
            salaryAccount.salaryAccount();
            Console.WriteLine();

            Television tv = new Television();
            Console.WriteLine("Multiple Inheritance - Interfaces");
            tv.turnOn();
            tv.changeChannel();
            tv.turnOff();
            Console.WriteLine();

            AC ac = new AC();
            ac.turnOn();
            ac.changeChannel();
            ac.turnOff();

        }

        public static void upcasting()
        {
            DogU d = new DogU();

            // Upcasting (Dog → Animal)
            AnimalU a = d;
            a.Eat();  
        }

        public static void downCasting()
        {
            AnimalU a = new DogU();
            a.Eat();

            DogU d = (DogU)a;
            d.Bark();

            AnimalU a2 = new AnimalU();
            //DogU d2 = (DogU)a2;   runtime error (invalid cast exception)
        }
    }

    //UPCASTING - Derived → Base (safe, implicit).
    //DOWNCASTING - Base → Derived (unsafe if object not of derived type, must be explicit).
    class AnimalU
    {
        public void Eat() => Console.WriteLine("Animal is eating");
    }

    class DogU : AnimalU
    {
        public void Bark() => Console.WriteLine("Dog is Barking");
    }
}
