using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class NonGenericCollections
    {
        public static void Display()
        {

            ArrayList list = new ArrayList();
            list.Add(10);                        // int
            list.Add("Samyu");                   // string
            list.Add(3.14);                      // double
            list.Insert(2, 20);                  //int
            list.Remove(3.14);                   //remove(value)
            //list.RemoveAt(1);                  removeAt(index)

            int[] arr =  { 1, 2, 3, 4 };
            list.AddRange(arr);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
            //list.Clear();                      clears all data present inside arrayList
            if (list.Contains("Samyu"))          //contains(value)
            {
                Console.WriteLine("Yes it contains name Samyu!");
            }
            else
            {
                Console.WriteLine("No it doesn't");
            }

            //ArrayList list1 = (ArrayList)list.Clone();
            //foreach(var item in list1)
            //{
            //    Console.WriteLine(item);
            //}



            //HASHTABLE
            Hashtable hs = new Hashtable();
            hs.Add(1, 10);
            hs.Add("Name", "sam");
            hs.Add("age", 20);

            hs.Remove("age");
            Console.WriteLine("\nHashTable");
            foreach(DictionaryEntry entry in hs)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }                                                                   //${} is string interpolation
            if (hs.ContainsKey("age"))
            {
                Console.WriteLine("The gn key is present");
            }
            else
            {
                Console.WriteLine("The gn key not is present");
            }

            if (hs.ContainsValue("sam"))
            {
                Console.WriteLine("The gn value is present");
            }
            else
            {
                Console.WriteLine("The gn value is not present");
            }

            //hs.Clear();              clears all key value pair in hashtable

            //foreach(DictionaryEntry entry in hs)
            //{
            //    Console.WriteLine($"{entry.Key}: {entry.Value}");
            //}


            //Stack
            Stack stack = new Stack();
            Console.WriteLine("\nStack");
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");
            stack.Push("Fifth");
            Console.WriteLine(stack.Peek());
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            if (stack.Contains(10))
            {
                Console.WriteLine("yes it does");
            }
            else
            {
                Console.WriteLine("no it doesn't");
            }
            //stack.Clear();              clears all value in stack





            //QUEUE
            Queue queue = new Queue();
            Console.WriteLine("\nQueue");
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            Console.WriteLine(queue.Peek());
            while(queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Clear();
            if(queue.Count != 0)
            {
                Console.WriteLine("has value");
            }
            else
            {
                Console.WriteLine("no value present");
            }


            //sorted list
            Console.WriteLine("\nSORTEDLIST");
            SortedList slist = new SortedList();

            slist.Add(2, "Two");
            slist.Add(4, "Four");
            slist.Add(1, "One");
            slist.Add(3, "Three");

            foreach(DictionaryEntry entry in slist)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            Console.WriteLine(slist.GetByIndex(3));

            //BITARRAY
            Console.WriteLine("\nBitArray");
            BitArray bitArr = new BitArray(4);
            bitArr[0] = true;
            bitArr[1] = false;
            bitArr[2] = true;
            bitArr[3] = false;

            foreach(bool bit in bitArr)
            {
                Console.WriteLine(bit);
            }

            BitArray bitArr1 = new BitArray(new bool[] { true, false, true, true });

            BitArray resultAND = bitArr.And(bitArr1);
            BitArray resultOR = bitArr.Or(bitArr1);
            BitArray resultXOR = bitArr.Xor(bitArr1);

            Console.WriteLine("AND: ");
            foreach(bool bit in resultAND)
            {
                Console.Write(bit + " ");
            }

            Console.WriteLine("\nOR: ");
            foreach (bool bit in resultOR)
            {
                Console.Write(bit + " ");
            }

            Console.WriteLine("\nXOR: ");
            foreach (bool bit in resultXOR)
            {
                Console.Write(bit + " ");
            }

        }
    }
}
