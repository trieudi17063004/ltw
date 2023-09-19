using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2
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
                if (value == 0)
                {
                    Console.WriteLine("Denominator cannot be zero. Setting to default value 1.");
                    denominator = 1;
                }
                else
                    denominator = value;
            }
        }
        public Fraction()
        {
            numerator = 0;
            denominator = 1;
            Simplify();
        }
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            if (denominator == 0)
            {
                Console.WriteLine("Denominator cannot be zero. Setting to default value 1.");
                denominator = 1;
            }
            else

                this.denominator = denominator;
            Simplify();
        }
        public Fraction(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
            Simplify();
        }
        private void Simplify()
        {
            int ucln = GCD(Numerator, Denominator);
            Numerator /= ucln;
            Denominator /= ucln;
        }
        private int GCD(int tuSo, int mauSo)
        {
            tuSo = Math.Abs(tuSo);
            mauSo = Math.Abs(mauSo);
            if (tuSo == 0)
                return mauSo;
            return GCD(mauSo % tuSo, tuSo);
        }
        public void Input()
        {
            Console.Write("Enter numerator: ");
            Numerator = int.Parse(Console.ReadLine());
            Console.Write("Enter denominator: ");
            int d;
            while (true)
            {
                d = int.Parse(Console.ReadLine());
                if (d != 0)
                {
                    break;
                }
                Console.WriteLine("Denominator cannot be zero. Please enter again.");
            }
            Denominator = d;
            Simplify();
        }
        public double Decimal()
        {
            return ((double)Numerator) / Denominator;
        }
        public static Fraction Add(Fraction p, Fraction q)
        {
            int newDenominator = p.Denominator * q.Denominator;
            int newNumerator = p.Denominator * q.Numerator + p.Numerator * q.Denominator;
            Fraction res = new Fraction(newNumerator, newDenominator);
            res.Simplify();
            return res;
        }
        public static Fraction Subtract(Fraction p, Fraction q)
        {
            int newDenominator = p.Denominator * q.Denominator;
            int newNumerator = p.Numerator * q.Denominator - p.Denominator * q.Numerator;
            Fraction res = new Fraction(newNumerator, newDenominator);
            res.Simplify();
            return res;
        }
        public static Fraction Multiply(Fraction p, Fraction q)
        {
            int newNum = p.Numerator * q.Numerator;
            int newDen = p.Denominator * q.Denominator;
            Fraction res = new Fraction(newNum, newDen);
            res.Simplify();
            return res;
        }
        public static Fraction Divide(Fraction p, Fraction q)
        {
            int newNum = p.Numerator * q.Denominator;
            int newDen = p.Denominator * q.Numerator;
            Fraction res = new Fraction(newNum, newDen);
            res.Simplify();
            return res;
        }
        public override string ToString()
        {
            return $"{Numerator} / {Denominator}";
        }
        public static Fraction operator -(Fraction p)
        {
            return new Fraction(-p.numerator, p.denominator);
        }
    }
}
