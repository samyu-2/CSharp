using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class IEnumurator
    {
        public static void Display()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1,10);
            ht.Add(2, 20);
            ht.Add(3, 30);
            ht.Add(4, 40);

            var x = ht.GetEnumerator();
            x.MoveNext();
            x.MoveNext();                                    //start search from 2
            var y = ht.Cast<DictionaryEntry>().FirstOrDefault(x2 => (int)x2.Key==3).Value;

            Dictionary<string, int> arr = new Dictionary<string, int>();
            arr.Add("apple", 20);
            arr.Add("banana", 50);
            arr.Add("cherry", 90);
            IEnumerable y1 = arr.AsEnumerable();




        }
    }
}
