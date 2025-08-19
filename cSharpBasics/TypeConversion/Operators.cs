using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBasics
{
    class Operators
    {
        public static void display()
        {
            Console.Write("&: ");
            Console.Write(40 & 42);
            Console.WriteLine();
            Console.Write("^: ");
            Console.Write(9^10);
            Console.WriteLine();
            string a = "hi";
            if(a is string)
            {
                Console.WriteLine("I am string");
            }

            if(a is int)
            {
                Console.WriteLine("I am int");
            }
            else
            {
                Console.WriteLine("I am not int");
            }

            object obj = "hello";
            string b = obj as string;
            Console.WriteLine(b);
            Console.WriteLine(1 << 5);

           unsafe
            {
                int c=10;
                int* ptr = &c;
                Console.WriteLine((int)ptr);
                Console.WriteLine(*ptr); 
            }
            Console.WriteLine(~10);

            Console.ReadLine();
            
        }
    }
}
