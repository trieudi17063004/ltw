using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    internal class MixedFraction: Fraction
    {
        public MixedFraction(int wholePart, int numerator, int denominator) : base(wholePart * denominator + numerator, denominator)
        {

        }
        public MixedFraction(Fraction f) : base(f.Numerator, f.Denominator)
        {

        }
        public override string ToString()
        {
            int tuso = this.Numerator;
            int mauso = this.Denominator;
            return $"{tuso / mauso}[{tuso % mauso}/{mauso}]";
        }
    }
}
