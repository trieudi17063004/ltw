using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1, 3);
            Fraction f2 = new Fraction(1, 2);
            Console.WriteLine($"f1 + f2 = {f1 + f2}");
            Console.WriteLine($"f1 - f2 = {f1 - f2}");
            Console.WriteLine($"f1 * f2 = {f1 * f2}");
            Console.WriteLine($"f1 / f2 = {f1 / f2}");

            MixedFraction mf1 = new MixedFraction(2, 1, 2);
            MixedFraction mf2 = new MixedFraction(1, 2, 3);
            Console.WriteLine($"mf1 + mf2 = {mf1 + mf2}");
            Console.WriteLine($"mf1 - mf2 = {mf1 - mf2}");
            Console.WriteLine($"mf1 * mf2 = {mf1 * mf2}");
            Console.WriteLine($"mf1 / mf2 = {mf1 / mf2}");
        }
    }
}
