using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    //CLASS
    class Car
    {
        public string brand;
        public string model;
        public string color;
        public int speed;
        public int fuelLevel;
        public bool isRunning;

        //METHODS DisplayInfo
        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {brand} - {model}, Color: {color}");
        }

        public void Accelerate(int increase)
        {
            speed += increase;
            Console.WriteLine($"Accelerated to speed {speed}Km/Hr");
        }

        public void Brake(int decrease)
        {
            speed -= decrease;
            speed = (speed < 0) ? 0 : speed;
            Console.WriteLine($"Slowed to speed {speed}Km/Hr");
        }


    }
    class CallCar
    {
        public static void Display()
        {
            //OBJECT car
            Car car = new Car();

            //FIELDS
            car.brand = "TOYOTA";
            car.model = "Corolla";
            car.color = "Grey";
            car.speed = 0;
            car.fuelLevel = 200;
            car.isRunning = true;

            car.DisplayInfo();
            car.Accelerate(100);
            car.Brake(20);
        }
    }

    class Student
    {
        public string Name;
        public int Age;
        public string Department;

        public Student()
        {
            this.Name = "Sara";
            this.Age = 20;
            this.Department = "cse";
        }

        public Student(string Name, int Age, string Department)
        {
            this.Name = Name;
            this.Age = Age;
            this.Department = Department;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nDepartment: {Department}");
        }
    }

    class CallStudent
    {
        public static void Display()
        {
            Student student = new Student();
            student.DisplayInfo();

            Student student1 = new Student("Charlie", 23, "EEE");
            student1.DisplayInfo();

        }
    }

    class Employee
    {
        public string Name;
        public double BasicSalary;

        public Employee(string Name, double BasicSalary)
        {
            this.Name = Name;
            this.BasicSalary = BasicSalary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}\nSalary: {BasicSalary}");
        }

        public void AnnualSalary()
        {
            Console.WriteLine($"{Name}'s Annual Salary is " + BasicSalary * 12);
        }
    }

    class CallEmployee
    {
        public static void Display()
        {
            Employee employee = new Employee("Tharun", 12000);
            employee.DisplayInfo();
            employee.AnnualSalary();
        }
    }
}
