using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            student.input();
            Console.WriteLine(student.toString());
            Staff staff = new Staff();
            staff.input();
            Console.WriteLine(staff.toString());
        }
    }
}
