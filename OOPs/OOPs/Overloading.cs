using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Calculator
    {
        public int Add(int a , int b)
        {
            return a + b;
        }

        public double Add(double a , double b)
        {
            return a + b;
        }

        public int Add(int a , int b , int c)
        {
            return a + b + c;
        }
    }
    class Overloading
    {
        //Same class, different parameter signature
        //Compile-time polymorphism
        public static void Display()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(3, 5));
            Console.WriteLine(calculator.Add(3.3, 5.5));
        }
    }
}
