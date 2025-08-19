using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Arrays
    {
        public static void Display()
        {
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 2;
            unsafe
            {
                int totalBytes = sizeof(int) * arr.Length;
                Console.WriteLine(totalBytes);
            }
            int[,,] arr2 = new int[5, 5, 5];
            Console.WriteLine(arr2.Length);

            string[,] arr3 = new string[2,2];
            arr3[0,0] = "h";
            // int index = Array.IndexOf(arr3, "hello");
            //Console.WriteLine(index);

            int[] arr4 = { 1, 2, 3, 4, 5 };
            Array.Clear(arr4,1,3);
            foreach (var item in arr4)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("Length: " + arr4.Length);

            int[] original = { 1, 2, 3, 4, 5 };
            int[] copy = new int[5];
            Array.Copy(original,copy,original.Length-2);
            for(int i = 0; i < copy.Length;i++)
            {
                Console.Write(copy[i]+ " ");
            } 
        }
    }
}
       