using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public Complex(int r, int i)
        {
            Real = r;
            Imaginary = i;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }

    class OperatorOverloadding
    {
        public static void ComplexDisplay()
        {
            Complex num1 = new Complex(3, 2);
            Complex num2 = new Complex(1, 7);

            Complex sum = num1 + num2;
            Complex diff = num1 - num2;

            Console.WriteLine($"Sum: {sum}");

            Console.WriteLine($"Difference: {diff}");         
        }

        public static void ComplexEmploeeDisplay()
        {
            ComplexEmploee emp1 = new ComplexEmploee("Alic", 50000);
            ComplexEmploee emp2 = new ComplexEmploee("Belly", 50000);
            ComplexEmploee emp3 = new ComplexEmploee("Charlie", 60000);

            Console.WriteLine(emp1 == emp2);
            Console.WriteLine(emp1 != emp3);
            Console.WriteLine(emp1 == emp3);
        }
    }

    class ComplexEmploee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public ComplexEmploee(string name,double salary)
        {
            Name = name;
            Salary = salary;
        }

        public static bool operator ==(ComplexEmploee e1, ComplexEmploee e2)
        {
            if (ReferenceEquals(e1, e2)) return true;

            if ((object)e1 == null || (object)e2 == null) return false;

            return e1.Salary == e2.Salary;
        }

        public static bool operator !=(ComplexEmploee e1, ComplexEmploee e2)
        {
            return !(e1 == e2);
        }

        public override bool Equals(object obj)
        {
            if(obj == null || !(obj is ComplexEmploee)) return false;

            return this.Salary == ((ComplexEmploee)obj).Salary;
        }

        public override int GetHashCode()
        {
            return Salary.GetHashCode();
        }
    }
}
