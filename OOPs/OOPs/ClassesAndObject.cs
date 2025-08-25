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

    class AsIs
    {

        public static void checkIs(object obj)
        {
            if (obj is string str)
            {
                Console.WriteLine($"Obj is string {str}");
            }
            else
            {
                Console.WriteLine($"Obj is not string, {obj}");
            }
        }

        public static void checkAs(object obj)
        {
            string str = obj as string;
            int? Int = obj as int?;
            if(str != null)
            {
                Console.WriteLine($"Casted string: {str}");
            }
            else if(Int != null)
            {
                Console.WriteLine($"Casted integer: {Int}");
            }
            else
            {
                Console.WriteLine("Casting failed");
            }
        }

        public static void Display()
        {
            object obj = "Hello World";
            checkIs(obj);
            checkAs(obj);

            object obj1 = 100;
            checkIs(obj1);
            checkAs(obj1);
        }
    }

    public partial class Partial
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public partial class Partial
    {
        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

    class CallPartial
    {
        public static void Display()
        {
            Partial p = new Partial();
            p.Name = "kailey";
            p.Display();
        }
    }


}
