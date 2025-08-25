using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Library1
    {
        private string[] books = new string[4];

        public string this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        public int this[string bookName]
        {
            get
            {
                for(int i = 0; i < books.Length; i++)
                {
                    if (books[i] == bookName)
                    {
                        return i;
                    }
                }
                return -1;
            }

        }
    }
    class Indexers
    {
        public static void Display()
        {
            Library1 library = new Library1();
            library[0] = "C#";
            library[1] = "Python";
            library[2] = "Java";

            Console.WriteLine(library[0]);
            Console.WriteLine(library[1]);
            Console.WriteLine(library["Java"]);
        }
    }
}
