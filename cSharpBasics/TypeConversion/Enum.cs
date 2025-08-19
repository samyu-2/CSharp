using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
   
    class Enum
    {
        enum State
        {
            TamilNadu,
            Kerala,
            AndhraPradesh,
            Rajasthan
        }
        public static void display()
        {
            Console.WriteLine((int)State.TamilNadu);
            Console.WriteLine((int)State.Kerala);
            Console.ReadLine();
        }

    }
}
