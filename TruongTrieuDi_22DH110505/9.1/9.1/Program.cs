using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.setRadius(5);
            Console.WriteLine(c.toString());
            Rectangle r = new Rectangle();
            r.setWidth(4);
            r.setLength(10);
            Console.WriteLine(r.toString());
            Square s = new Square();
            s.setSide(5);
            Console.WriteLine(s.toString());
            Console.ReadKey();
        }
    }
}
