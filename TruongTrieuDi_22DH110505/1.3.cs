using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    internal class Program
    {
        static void PrintColumn(int[,] a, int k)
        {
            Console.WriteLine();
            if (k < 0 && k >= a.GetLength(1))
            {
                Console.WriteLine("Invalid k");
            }
            else
            {
                for (int r = 0; r < a.GetLength(0); r++)
                {
                    Console.Write(a[r, k] + " ");
                }
            }
        }
    }
}
