using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    internal class Program
    {
      
            static void Input2DArray(out int[,] a, out int k)
            {
                int m, n;
                string line = Console.ReadLine();
                string[] nums = line.Split(' ');
                m = int.Parse(nums[0]);
                n = int.Parse(nums[1]);
                k = int.Parse(nums[2]);
                a = new int[m, n];
                for (int r = 0; r < a.GetLength(0); r++)
                {
                    line = Console.ReadLine();
                    nums = line.Split(' ');
                    for (int c = 0; c < a.GetLength(1); c++)
                    {
                        a[r, c] = int.Parse(nums[c]);
                    }
                }
            }
            static void PrintRow(int[,] a, int k)
            {
                Console.WriteLine();
                if (k < 0 && k >= a.GetLength(0))
                {
                    Console.WriteLine("Invalid k");
                }
                else
                {
                    for (int c = 0; c < a.GetLength(1); c++)
                    {
                        Console.Write(a[k, c] + " ");

                        
                    
}
                }
            }
            static void Main(string[] args)
            {
                int[,] a;
                int k;
                Input2DArray(out a, out k);
                PrintRow(a, k);
            }
     }
    
}
