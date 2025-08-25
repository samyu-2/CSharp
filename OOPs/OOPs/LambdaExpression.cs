using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class LambdaExpression
    {
        public static void Display()
        {
            //SIMPLE LAMBDA
            Func<int, int> sq = x => x * x;
            Console.WriteLine(sq(5));

            //MULTIPLE PARAMETERS
            //USING Func<> takes int input and returns int
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine(add(4, 5));

            //BLOCK OF CODE
            Func<int, int, bool> isDivisible = (a, b) =>
              {
                  if (a == 0) return false;
                  return b % a == 0 ? true : false;
              };
            Console.WriteLine(isDivisible(2, 40));

            //WITH DELEGATES
            checkNum isEven = x => x % 2 == 0;
            Console.WriteLine(isEven(4));

            //WITH LINQ
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            var even = nums.Where(n => n % 2 == 0);
            foreach(var num in even)
            {
                Console.WriteLine(num);
            }

            //USING Action<> takes string input and returns void
            Action<string> greet = name => Console.WriteLine("Hello " + name);
            greet("Alice");

            //USING Predicate<> takes int input and returns bool
            Predicate<int> isEven1 = num => num % 2 == 0;
            Console.WriteLine(isEven1(49));
            Console.WriteLine(isEven1(40));

            Console.WriteLine();
            int[] numss = { 3, 6, 9, 12, 15, 18, 21 };
            Predicate<int> divisibleBy3 = num => num % 3 == 0;
            Func<int, int> square = num => num * num;
            Action<int> display = num => Console.WriteLine(num);

            foreach(int num in numss)
            {
                if (divisibleBy3(num))
                {
                    int sqNum = square(num);
                    display(sqNum);
                }
            }

        }
        delegate bool checkNum(int num);
    }
}
