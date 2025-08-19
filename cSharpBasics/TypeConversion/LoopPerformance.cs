using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace TypeConversion
{
    class LoopPerformance
    {
        public static void Display()
        {
            int[] data = new int[10000000];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i;
            }
            Stopwatch sw = new Stopwatch();

            sw.Start();
            for (int i = 0; i < data.Length; i++)
            {
                int temp = data[i] * 2;
            }
            sw.Stop();
            Console.WriteLine("For Loop: " + sw.ElapsedMilliseconds);
            

            
        }
    }
}
