using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    internal class Program
    {
        //Câu a
        static void NhapMang1(out int[,] intArr)
        {
            //Nhập số dòng, số cột
            int rows, cols;
            Console.Write("Nhập số dòng: ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột: ");
            cols = int.Parse(Console.ReadLine());
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
        //Câu b
        static int[,] NhapMang2()
        {
            int rows, cols;
            Console.Write("Nhập số dòng: ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột: ");
            cols = int.Parse(Console.ReadLine());
            int[,] intArr = new int[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write($"Nhập số nguyên ở dòng {r} cột {c}: ");
                    intArr[r, c] = int.Parse(Console.ReadLine());
                }
            }
            return intArr;
        }
        //Câu c
        static void NhapMang3(int[,] intArr)
        {
            for (int r = 0; r < intArr.GetLength(0); r++)
            {
                for (int c = 0; c < intArr.GetLength(1); c++)
                {
                
                    Console.Write($"Nhập số nguyên ở dòng {r} cột {c}: ");
                    intArr[r, c] = int.Parse(Console.ReadLine());
                }
            }
        }
        //Câu d
        static void XuatMang(int[,] intArr)
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
    }
}
