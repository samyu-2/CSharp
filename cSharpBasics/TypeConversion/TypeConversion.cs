using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpBasics.Controller
{
    class TypeConversion
    {
        public static void print()
        {
            Console.WriteLine("String");
            int num = 10;
            string a = Convert.ToString(num);
            Console.WriteLine(a);
            string b = num.ToString();
            Console.WriteLine(b);

            Console.WriteLine("Integer");
            string str = "10";
            int c = Convert.ToInt32(str);
            Console.WriteLine(c);
            int e = int.Parse(str);
            Console.WriteLine(e);
            int g;
            bool h = int.TryParse(str,out g);
            Console.WriteLine(g);

            Console.WriteLine("Decimal");
            string str2 = "20.4";
            double d = Convert.ToDouble(str2);
            Console.WriteLine(d);
            double f = double.Parse(str2);
            Console.WriteLine(f);
            double i;
            bool j = double.TryParse(str2, out i);
            Console.WriteLine(i);
            Console.ReadLine();

        }

    }
}

