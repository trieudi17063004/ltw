using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Calculator
    {
        public Calculator() { }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(int a, int b)
        {
            return a / b;
        }
        public double Divide(double a, double b)
        {
            return a / b;
        }

        public int Min(int a, int b)
        {
            return a < b ? a : b;
        }
        public int Min(int a, int b, int c)
        {
            int min = a;
            if (min > b)
                min = b;
            if (min > c)
                min = c;
            return min;
        }
        public double Min(double a, double b, double c)
        {
            double min = a;
            if (min > b)
                min = b;
            if (min > c)
                min = c;
            return min;
        }

        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        public int Max(int a, int b, int c)
        {
            int max = a;
            if (max < b)
                max = b;
            if (max < c)
                max = c;
            return max;
        }
        public double Max(double a, double b, double c)
        {
            double max = a;
            if (max < b)
                max = b;
            if (max < c)
                max = c;
            return max;
        }
    }
}
