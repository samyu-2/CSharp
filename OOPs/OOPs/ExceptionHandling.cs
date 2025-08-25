using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class ExceptionHandling
    {
        public static void Display()
        {
            try
            {
                int a = 10;
                int b = 0;
                int result = a / b;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("General error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed");
            }


            //THROWING EXCEPTION
            try
            {
                Console.WriteLine("Enter Age:");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Mark:");
                int mark = Convert.ToInt32(Console.ReadLine());
                validCredentials(age, mark);
                Console.WriteLine($"Candidate is eligible. Age: {age}, Marks: {mark}");
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (InvalidMarksException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            try
            {
                Console.WriteLine("Enter Age:");
                int age = Convert.ToInt32(Console.ReadLine());
                checkAge(age);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            
        }

        static void checkAge(int age)
        {
            if(age < 18)
            {
                throw new ArgumentException("Age must be 18 or above");
            }
            else
            {
                Console.WriteLine("Valid age");
            }
        }

        static void validCredentials(int age, int mark)
        {
            if(age < 18)
            {
                throw new InvalidAgeException("Not eligible for exam (Age must be 18+)");
            }
            
            if(mark > 100 || mark < 0)
            {
                throw new InvalidMarksException("Invalid marks (must be between 0–100).");
            }
        }

        public class InvalidAgeException : Exception
        {
            public InvalidAgeException(string message) : base(message)   {     }
        }

        public class InvalidMarksException : Exception
        {
            public InvalidMarksException(string message) : base(message)  {   }
        }

    }
}
