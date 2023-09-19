using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Fraction
    {
        private int numerator;
        private int denominator;

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value != 0)
                {
                    denominator = value;
                    if (denominator < 0)
                    {
                        numerator = -numerator;
                        denominator = -denominator;
                    }
                }
                else
                {
                    Console.WriteLine("Mau so phai khac 0. " +
                        "Mau so duoc thiet lap mac dinh la 1");
                    denominator = 1;
                }
            }
        }
        public Fraction()
        {
            this.numerator = 0;
            this.denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
            this.Simplify();
        }
        public Fraction(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
        }

        private static int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }
        public void Simplify()
        {
            int ucln = GCD(this.numerator, this.denominator);
            this.numerator = this.numerator / ucln;
            this.denominator = this.denominator / ucln;
        }
        public double ToDecimal()
        {
            return numerator / denominator + numerator % denominator;
        }
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        public Fraction Add(Fraction f)
        {
            int tuso = numerator * f.denominator + f.numerator * denominator;
            int mauso = denominator * f.denominator;
            return new Fraction(tuso, mauso);
        }
        public Fraction Subtract(Fraction f)
        {
            int tuso = numerator * f.denominator - f.numerator * denominator;
            int mauso = denominator * f.denominator;
            return new Fraction(tuso, mauso);
        }
        public Fraction Multiply(Fraction f)
        {
            int tuso = numerator * f.numerator;
            int mauso = denominator * f.denominator;
            return new Fraction(tuso, mauso);
        }
        public Fraction Divide(Fraction f)
        {
            int tuso = numerator * f.denominator;
            int mauso = denominator * f.numerator;
            return new Fraction(tuso, mauso);
        }

        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a.numerator, a.denominator);
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return a.Add(b);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return a.Subtract(b);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return a.Multiply(b);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            return a.Divide(b);
        }


        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.Numerator == b.Numerator && a.Denominator == b.Denominator;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }
        public static bool operator >(Fraction a, Fraction b)
        {
            return a.ToDecimal() > b.ToDecimal();
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            return a.ToDecimal() < b.ToDecimal();
        }
        public static bool operator >=(Fraction a, Fraction b)
        {
            return !(a < b);
        }
        public static bool operator <=(Fraction a, Fraction b)
        {
            return !(a > b);
        }
    }
}
