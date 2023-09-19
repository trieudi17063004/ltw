using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    internal class Program
    {
        static void Input2DArray(out int[,] intArr)
        {
            //Nhập số dòng, số cột
            int rows, cols;
            do
            {
                Console.Write("Nhập số dòng: ");
                rows = int.Parse(Console.ReadLine());
            } while (rows <= 1 || rows >= 100);
            do
            {
                Console.Write("Nhập số cột: ");
                cols = int.Parse(Console.ReadLine());
            } while (cols <= 1 || cols >= 100);
            //Khởi tạo mảng
            intArr = new int[rows, cols];
            //Nhập giá trị cho các phần tử của mảng
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)

                    
            
{
                    Console.Write($"Nhập số nguyên ở dòng {r} cột {c}: ");
                    intArr[r, c] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Output2DArray(int[,] intArr)
        {
            for (int r = 0; r < intArr.GetLength(0); r++)
            {
                for (int c = 0; c < intArr.GetLength(1); c++)
                {
                    Console.Write(intArr[r, c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        //Câu a
        static int SumOfRow(int[,] a, int k)
        {
            int sum = 0;
            if (k < 0 && k >= a.GetLength(0))
            {
                Console.WriteLine("Invalid k");
            }
            else
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    sum += a[k, c];
                }
            }
            return sum;
        }
        //Câu b
        static int SumOfColumn(int[,] a, int k)
        {
            int sum = 0;
            if (k < 0 && k >= a.GetLength(1))
            {
                Console.WriteLine("Invalid k");
            }
            else
            {
                for (int r = 0; r < a.GetLength(0); r++)
                {
                    sum += a[r, k];
                }
            }
            return sum;

            
        
}
        //Câu c
        static int SumOfTable(int[,] a)
        {
            int sum = 0;
            for (int r = 0; r < a.GetLength(0); r++)
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    sum += a[r, c];
                }
            }
            return sum;
        }
        //Câu d
        static int SumOfEvenNumbers(int[,] a)
        {
            int sum = 0;
            for (int r = 0; r < a.GetLength(0); r++)
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    if (a[r, c] % 2 == 0)
                        sum += a[r, c];
                }
            }
            return sum;
        }
        //Câu e
        static int SumOfOddNumbers(int[,] a)
        {
            int sum = 0;
            for (int r = 0; r < a.GetLength(0); r++)
            {
                for (int c = 0; c < a.GetLength(1); c++)
                {
                    if (a[r, c] % 2 != 0)
                        sum += a[r, c];
                }
            }
            return sum;
        }
        //Câu f
        static double AverageOfTable(int[,] a)
        {
            return (1.0 * SumOfTable(a) / (a.GetLength(0) * a.GetLength(1)));
        }
        static void Main(string[] args)
        {

            
        
            int[,] a;
            Console.WriteLine("Nhập bảng a!");
            Input2DArray(out a);
            Console.WriteLine("Bảng a vừa nhập: ");
            Output2DArray(a);
            Console.Write("Nhập k: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Tổng các phần tử nằm trên dòng thứ {0} của bảng a: {1}", k, SumOfRow(a, k));
            Console.WriteLine("Tổng các phần tử nằm trên cột thứ {0} của bảng a: { 1} ",k,SumOfColumn(a,k));
            Console.WriteLine("Tổng tất cả các phần tử trong bảng a: " + SumOfTable(a));
            Console.WriteLine("Tổng tất cả các phần tử là số chẵn trong bảng a: " + SumOfEvenNumbers(a));
            Console.WriteLine("Tổng tất cả các phần tử là số lẻ trong bảng a: " + SumOfOddNumbers(a));
            Console.WriteLine("Giá trị trung bình của tất cả các phần tử trong bảng a:"+AverageOfTable(a));
        }
    }
}
