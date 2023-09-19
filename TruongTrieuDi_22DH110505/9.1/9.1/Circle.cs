using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1
{
        class Circle : Shape
        {
            protected double radius;

            public Circle() { }

            public Circle(double radius, string color, Boolean filled) : base(color, filled)
            {
                this.radius = radius;
            }

            public double getRadius()
            {
                return this.radius;
            }

            public void setRadius(double radius)
            {
                this.radius = radius;
            }

            public override double getArea()
            {
                return 2 * this.radius * Math.PI;
            }


            public override double getPerimeter()
            {
                return Math.Pow(this.radius, 2) * Math.PI;
            }

            public override string toString()
            {
                return $"Circle[Radius: {radius}, Area: {getArea()}, Perimeter: {getPerimeter()}]";
            }
        }
 }