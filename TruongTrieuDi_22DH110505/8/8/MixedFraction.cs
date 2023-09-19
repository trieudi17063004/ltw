using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class MixedFraction : Fraction
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
        public static MixedFraction operator +(MixedFraction a, MixedFraction b)
        {
            Fraction f1 = new Fraction(a.Numerator, a.Denominator);
            Fraction f2 = new Fraction(b.Numerator, b.Denominator);
            return new MixedFraction(f1 + f2);
        }
        public static MixedFraction operator -(MixedFraction a, MixedFraction b)
        {
            Fraction f1 = new Fraction(a.Numerator, a.Denominator);
            Fraction f2 = new Fraction(b.Numerator, b.Denominator);
            return new MixedFraction(f1 - f2);
        }
        public static MixedFraction operator *(MixedFraction a, MixedFraction b)
        {
            Fraction f1 = new Fraction(a.Numerator, a.Denominator);
            Fraction f2 = new Fraction(b.Numerator, b.Denominator);
            return new MixedFraction(f1 * f2);
        }
        public static MixedFraction operator /(MixedFraction a, MixedFraction b)
        {
            Fraction f1 = new Fraction(a.Numerator, a.Denominator);
            Fraction f2 = new Fraction(b.Numerator, b.Denominator);
            return new MixedFraction(f1 / f2);
        }
        public static MixedFraction operator -(MixedFraction a)
        {
            Fraction f1 = new Fraction(a.Numerator, a.Denominator);
            return new MixedFraction(-f1);
        }
    }
}
