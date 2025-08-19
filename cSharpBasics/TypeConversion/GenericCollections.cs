using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class GenericCollections
    {
        public static void Display()
        {
            //LIST
            Console.WriteLine("LIST<T>");
            List<string> fruits = new List<string>();
            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("kiwi");
            fruits.Add("strawberry");

            fruits.Insert(1, "orange");
            foreach(string fruit in fruits)
            {
                Console.Write(fruit + " ");
            }
            Console.Write("\n");
            fruits.Remove("apple");
            fruits.Sort();
            foreach (string fruit in fruits)
            {
                Console.Write(fruit + " ");
            }


            //DICTIONARY
            Console.WriteLine("\n " +
                "\nDICTIONARY");
            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(1, "sam");
            students.Add(2, "mithu");
            students.Add(3, "vinu");

            students[4] = "ragav";

            Console.WriteLine("contains key 3: " + students.ContainsKey(3));

            Console.WriteLine("contains value anu: " + students.ContainsValue("anu"));

            if(students.TryGetValue(3,out string name))
            {
                Console.WriteLine("Found: " + name);
            }

            students.Remove(4);
            Console.WriteLine("after removing 4: " + students.Count);

            students.Clear();
            Console.WriteLine("after clearing the student dic: " + students.Count);



            //HASHSET
            Console.WriteLine("\nHASHSET");
            HashSet<string> fruitss = new HashSet<string>();

            fruitss.Add("Apple");
            fruitss.Add("Banana");
            fruitss.Add("Orange");
            fruitss.Add("Banana");  // Duplicate, will be ignored

            Console.WriteLine("Fruits Count: " + fruitss.Count);  // 3

            HashSet<string> tropical = new HashSet<string>() { "Banana", "Mango" };

            fruitss.UnionWith(tropical);  // Adds "Mango"
            fruitss.Remove("Apple");

            Console.WriteLine("All Fruits:");
            foreach (var fruit in fruitss)
                Console.WriteLine(fruit);
        }
    }


}
