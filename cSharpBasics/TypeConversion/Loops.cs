using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TypeConversion
{
    class Loops
    {
        public static void Display()
        {
            Stopwatch sw = new Stopwatch();

            string[] fruits = { "Apple", "Banana", "Cherries", "Dragon Fruit", "Kiwi", "Berries" };
            Console.WriteLine("For loop (i++): ");
            sw.Start();
            for(int i = 0; i < fruits.Length; i+=2 )
            {
                Console.Write(fruits[i] + " ");
            }
            sw.Stop();
            //int forLoop = sw.ElapsedMilliseconds;
            Console.WriteLine("\nFor Loop Execution: " + sw.Elapsed + "ms\n" );
            sw.Reset();

            Console.WriteLine("For loop (++i): ");
            for (int i = 0; i < fruits.Length; ++i)
            {
                Console.Write(fruits[i] + " ");
            }
            Console.WriteLine("\n");
            

            Console.WriteLine("ForEach loop: ");
            sw.Start();
            foreach (var fName in fruits)
            {
                Console.Write(fName + " ");
            }
            sw.Stop();
            Console.WriteLine("\nForEach Loop Execution: " + sw.Elapsed + "ms\n");
            sw.Reset();


            Console.WriteLine("While loop (i++ at end): ");
            sw.Start();
            int j = 0;
            while(j < fruits.Length)
            {
                Console.Write(fruits[j] + " ");
                j++;
            }
            sw.Stop();
            Console.WriteLine("\nWhile Loop Execution: " + sw.Elapsed + "ms\n");
            sw.Reset();

            Console.WriteLine("While loop (++i at end): ");
            j = 0;
            while (j < fruits.Length)
            {
                Console.Write(fruits[j] + " ");
                ++j;
            }
            Console.WriteLine();
            Console.WriteLine();

            //string[] fruits = { "Apple", "Banana", "Cherries", "Dragon Fruit", "Kiwi", "Berries" };
            Console.WriteLine("While loop (i++ in beginning): ");
            j = 0;
            while (j < fruits.Length - 1)
            {
                j++;
                Console.Write(fruits[j] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("While loop (++i in beginning): ");
            j = 0;
            while (j < fruits.Length - 1)
            {
                ++j;
                Console.Write(fruits[j] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Do-While:");
            sw.Start();
            j = 0;
            do
            {
                Console.Write(fruits[j] + " ");
                j++;
            }
            while (j < fruits.Length);
            sw.Stop();
            Console.WriteLine("\nDo-While Loop Execution: " + sw.Elapsed + "ms\n");
            sw.Reset();
            Console.ReadLine();
        }
    }
}
