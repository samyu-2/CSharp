using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class A
    {
        public string name;
        public int age;
    }

    class B : A
    {
        public bool premium;
    }

    class c : B
    {

    }

    class Obj
    {
        public static void Display()
        {
            A objA = new B { name = "Sukant", age = 25, premium = true };
            c objB = objA as c;

            if (objB != null)
            {
                Console.WriteLine("Name: " + objB.name);
                Console.WriteLine("Premium: " + objB.premium);
            }
            else
            {
                Console.WriteLine("Cast failed.");
            }

            int e = 5, f = 6;
            Console.WriteLine("Q1: " + (++e + f));

            int g = 7, h = 3;
            Console.WriteLine("Q2: " + (g-- * h));

            int i = 12, j = 4, k = 2;
            Console.WriteLine("Q3: " + ((i / j) / k));

            int l = 5, m = 2;
            Console.WriteLine("Q4: " + (l * 2 & m + 1));

            double n = 3.9;
            Console.WriteLine("Q5: " + (-(int)n + 1));

            int o = 1, p = 2, q = 3;
            Console.WriteLine("Q6: " + (o++ + ++p * q--));

            string r = null;
            string s = r ?? "Default";
            Console.WriteLine("Q7: " + s);

            int t = 0;
            bool result8 = (t++ == 0) || (t++ > 0);
            Console.WriteLine("Q8: " + result8 + ", t = " + t);

            int u = 5, v = 10;
            int result9 = (u > v ? u : v) * 2;
            Console.WriteLine("Q9: " + result9);

            int w = 4;
            Console.WriteLine("Q10: " + (~w << 1));

            int ea = 5, fb = 3, gc = 4;
            int r1 = ++ea * fb-- + gc / 2;
            Console.WriteLine("Q1: " + r1);

            int hd = 7, ie = 3, jf = 5;
            int r2 = (hd & ie) * jf + (~jf);
            Console.WriteLine("Q2: " + r2);

            int kg = 10, lh = 20;
            string r3 = (kg++ > --lh) ? "High" : "Low";
            Console.WriteLine("Q3: " + r3);

            int mi = 4, nj = 8, ok = 3;
            int r4 = (mi * 2 > nj) ? nj : nj - ok * 2;
            Console.WriteLine("Q4: " + r4);

            int pl = 5;
            string r5 = (pl++ == 5) ? ((pl == 6) ? "Correct" : "Wrong") : "Invalid";
            Console.WriteLine("Q5: " + r5);

            int qm = 0;
            bool r6 = (qm++ == 0) && (qm++ == 1) || (qm++ == 3);
            Console.WriteLine("Q6: " + r6 + ", qm = " + qm);

            int rn = 9, so = 2;
            double r7 = (double)(rn / so);
            Console.WriteLine("Q7: " + r7);

            double r8 = (double)rn / so;
            Console.WriteLine("Q8: " + r8);

            string tp = null;
            string uq = tp ?? ((5 > 2) ? "Yes" : "No");
            Console.WriteLine("Q9: " + uq);

            int vr = 2, ws = 3;
            int r10 = (vr << 2) + (ws >> 1);
            Console.WriteLine("Q10: " + r10);

            Console.ReadLine();
        }
    }
}
