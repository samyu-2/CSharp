using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class ConditionalStatement
    {
        public static void Display()
        {
            int age = 18;
            Console.WriteLine("If.....Else:");
            if(age >= 18)
            {
                Console.WriteLine("Eligible to vote");
            }
            else
            {
                Console.WriteLine("Not eligible to vote");
            }

            Console.WriteLine();
            Console.WriteLine("Switch:");

            int num = 4;
            switch (num)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                default:
                    Console.WriteLine("Enter val between 1 - 4");
                    break;
            }
            Console.ReadLine();
        }
    }
}
