using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1
{
    class Square : Rectangle
    {
        public Square() { }
        public Square(double side, string color, Boolean filled) : base(color, filled)
        {
            this.width = side;
        }
        public double getSide()
        {
            return this.width;
        }
        public void setSide(double side)
        {
            this.width = side;
            this.length = side;
        }
        public override string toString()
        {
            return $"Square[Side: {getSide()}, Area: {getArea()}, Perimeter: {getPerimeter()}]";
        }
    }
}
