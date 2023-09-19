using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fr = new Fraction(11, 3);
            Console.WriteLine(fr.ToString());
            MixedFraction mfr = new MixedFraction(fr);
            Console.WriteLine(mfr.ToString());
        }
    }
}
