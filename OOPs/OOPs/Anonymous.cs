using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    
    class BasicAnonymous
    {
        delegate void ShowMessage(string msg);
        public static void Display()
        {
            ShowMessage message = delegate (string text)
            {
                Console.WriteLine("Message: " + text);
            };
            message("Hello Anonymous");
        }
    }

    class EventAnonymous
    {
        public static void Display()
        {
            Button btn = new Button();
            btn.Click += delegate (object sender, EventArgs e)
            {
                Console.WriteLine("Button Clicked!");
            };

            btn.OnClick();
        }
    }

    class Button
    {
        public event EventHandler Click;
        public void OnClick()
        {
            if(Click != null)
            {
                Click(this, EventArgs.Empty);
            }
        }
    }

    class ParameterAnonymous
    {
        delegate int Square(int x);

        public static void Display()
        {
            Square sq = delegate (int x)
            {
                return x * x;
            };
            Console.WriteLine(sq(5));
        }
    }

    class PracticeAnonymous
    {
        delegate bool isEven(int arr);

        public static void Display()
        {
           int[] arr = { 1, 2, 3, 4, 5, 6 };
           isEven even = delegate(int num)
           {
               return num % 2 == 0;
           };
           foreach (int i in arr)
           {
                if (even(i))
                {
                    Console.WriteLine(i);
                }
           }
        }
    }
}
