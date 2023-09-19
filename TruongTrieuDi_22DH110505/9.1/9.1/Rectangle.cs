using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1
{
    class Rectangle : Shape
    {
        protected double width;
        protected double length;
        public Rectangle() { }
        public Rectangle(double width, double length, string color, Boolean filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }

        public Rectangle(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public double getWidth()
        {
            return this.width;
        }
        public void setWidth(double width)
        {
            this.width = width;
        }
        public double getLength()
        {
            return this.length;
        }
        public void setLength(double length)
        {
            this.length = length;
        }

        public override double getArea()
        {
            return width * length;
        }

        public override double getPerimeter()
        {
            return (width + length) * 2;
        }

        public override string toString()
        {
            return $"Rectangle[Width: {width}, Length: {length}, Area: {getArea()}, Perimeter: {getPerimeter()}]";
        }
    }
}

