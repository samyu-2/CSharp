using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    struct Point
    {
        public int X;
        public int Y;

        public Point(int x , int y)
        {
            X = x;
            Y = y;
        }
    }

    class Person
    {
        public string Name;
        public int Age;

        public Person(string Name, int Age)
        {
            Name = Name;
            Age = Age;
        }
    }
    class StructClass
    {
        public static void Display()
        {
            Point p1 = new Point(30, 40);
            Point p2 = p1;
            Console.WriteLine($"Original val of p1.X: {p1.X}");
            p2.X = 20;
            Console.WriteLine($"Changed val of p2.X: {p2.X}\nThis is Struct -- Value Copy(Stack)\n");

            Person person1 = new Person("charls",23);
            Person person2 = person1;
            person2.Name = "David";
            Console.WriteLine($"Original Name of person 1: {person1.Name}");   // (Actual name is charls as we used person 1 as reference copy charls is changed into david)
            Console.WriteLine($"Changed Name of person 2: {person2.Name}\nThis is Class -- Reference Copy(Heap)");


        }
    }
}
