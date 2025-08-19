using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Delegates
    {
        public delegate void myDelegate(string message);
        public delegate void myDelegates(int a, int b);
        public delegate void MyDelegate(object data);

        public static void MethodOne(string message)
        {
            Console.WriteLine("Message from MethodOne: " + message );
        }

        public static void MethodTwo(string message)
        {
            Console.WriteLine("Message from MethodTwo: " + message);
        }

        public void sum(int a , int b)
        {
            Console.WriteLine(a + b);
        }

        public void diff(int a , int b)
        {
            Console.WriteLine(a - b);
        }

        static void MethodWithInt(object data)
        {
            if(data is int num)
            {
                Console.WriteLine($"Integer Method: {num}");
            }
        }

        static void MethodWithString(object data)
        {
            if(data is string text)
            {
                Console.WriteLine($"String method: {text}");
            }
        }

        
        public static void Display()
        {
            Delegates display = new Delegates();
            myDelegate del = MethodOne;
            del += MethodTwo;
            del("Hello world");
            del -= MethodTwo;
            del("Hello world!!");
            Console.WriteLine();

            myDelegates dele = display.sum;
            dele += display.diff;
            dele(5,2);
            Console.WriteLine();

            MyDelegate deleg = MethodWithInt;
            deleg += MethodWithString;
            deleg(40);
            deleg("Hello");
            Console.WriteLine();

          



        }
    }
}
