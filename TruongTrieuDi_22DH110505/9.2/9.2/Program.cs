using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(5, 2);
            Fraction f2 = new Fraction(3, 5);

            Fraction kq1 = new Fraction();
            kq1 = Fraction.Add(f1, f2);
            Console.WriteLine(kq1.ToString());

            Fraction kq2 = new Fraction();
            kq2 = Fraction.Subtract(f1, f2);
            Console.WriteLine(kq2.ToString());

            Fraction kq3 = new Fraction();
            kq3 = Fraction.Multiply(f1, f2);
            Console.WriteLine(kq3.ToString());

            Fraction kq4 = new Fraction();
            kq4 = Fraction.Divide(f1, f2);
            Console.WriteLine(kq4.ToString());

            Console.ReadKey();
        }
    }
}
