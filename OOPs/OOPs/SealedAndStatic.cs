using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    //SEALED
    class A
    {
        public virtual void Show()
        {
            Console.WriteLine("A Show");
        }
    }

    class B : A
    {
        public sealed override void Show()
        {
            Console.WriteLine("B show");
        }
    }

    class C : B
    {
        //public override void Show()  --> Not possible 
    }

    //STATIC - common to all
    //NON-STATIC - individual copy per object
    class Library
    {
        //Belongs to the class,shared by all objects and change is visible to all instances.
        public static string LibraryName;
        public static int TotalBook;
        //Belongs to the object,each object keeps its own value
        public string BookName;

        
        static Library()
        {
            Console.WriteLine("Static constructor called");
            LibraryName = "Central Library";
            TotalBook = 3000;
        }

        public static void ShowLibraryInfo()
        {
            Console.WriteLine($"Library: {LibraryName},Book: {TotalBook}");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Library: {LibraryName},Book: {BookName}");
        }
    }

    class SealedAndStatic
    {
        public static void SealedDisplay()
        {
            B b = new B();
            b.Show();
        }

        public static void StaticDisplay()
        {
            Library.ShowLibraryInfo();
            Library.LibraryName = "central lib";   //will make changes globally
            Library.ShowLibraryInfo();

            Library library = new Library();
            library.BookName = "C# Basics";
            library.ShowInfo();

            Library library1 = new Library();
            library1.BookName = "Data Structure";
            Library.LibraryName = "City Lib";
            Library.ShowLibraryInfo();
            library1.ShowInfo();
        }
    }
}
