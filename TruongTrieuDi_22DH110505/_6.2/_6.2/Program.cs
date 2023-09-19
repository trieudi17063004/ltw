using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student sv1 = new Student();
            sv1.Input();
            sv1.PrintInfo();
            Student sv2 = new Student("22DH112244", "Nguyen Van An", 2005, true, "T22308");
            sv2.PrintInfo();
        }

    }
}
