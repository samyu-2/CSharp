using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Parent
    {
        public void parent()
        {
            Console.WriteLine("Parent Class");
        }
    }
    class Child : Parent //single-level-inheritance    //Child is derived class
    {
        public void child()
        {
            Console.WriteLine("Child Class");
        }
    } 



    class Inheritance
    {
        public static void InheritanceDisplay()
        {
            Child child = new Child();
            child.child();
            child.parent();

        }
        public static void AnimalDisplay()
        {
            Dog dog = new Dog();
            dog.sound();
            dog.eat();
        }

        public static void CarDisplay()
        {
            //CarI car = new CarI();
            //car.model = "Corolla";
            //car.brand = "TOYOTA";

           // car.Drive();
            //car.ShowCarInfo();

            SportsCar sportsCar = new SportsCar("Ferrari", "488 GTB");
            sportsCar.Drive();
            sportsCar.ShowCarInfo();
        } 
    }


    class Animal
    {
        public void eat()
        {
            Console.WriteLine("Animal eats");
        }
    }
    class Dog : Animal
    {
        public void sound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    

    class Vehicle
    {
        public string brand;

        public Vehicle(string brand)
        {
            this.brand = brand;
            Console.WriteLine("Vehicle constructor called");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Driving a vehicle");
        }
    }

    class CarI : Vehicle
    {
        public string model;

        public CarI(string brand, string model) : base(brand)
        {
            this.model = model;
            Console.WriteLine("Car constructor called");
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Brand: {brand}\nModel: {model}");
        }

        public override void Drive()
        {
            Console.WriteLine("Driving a car");
        }
    }

    class SportsCar : CarI
    {
        public SportsCar(string brand, string model) : base(brand, model)
        {

        }

        public override void Drive()
        {
            base.Drive();  //calls carI drive() first
            Console.WriteLine("Driving sports car");
        }
    }
}
