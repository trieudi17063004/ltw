using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void nhapmang(out int[] a)
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xuatmang(int[] a)
        {
            Console.Write("Gia tri cua mang la: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        static int chan(int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            if (max % 2 == 0)
            {
                max += 2;
            }
            else
            {
                max += 1;
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] a;
            nhapmang(out a);
            xuatmang(a);
            Console.WriteLine($"So chan nho nhat lon hon moi gia tri trong mang la: {chan(a)}");
            Console.ReadKey();
        }
    }
}

   