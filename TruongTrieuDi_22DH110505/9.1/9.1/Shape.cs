using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1
{
    abstract class Shape
    {
        protected string color;
        protected Boolean filled;
        public Shape() { }
        public Shape(string color, Boolean filled)
        {
            this.color = color;
            this.filled = filled;
        }
        public string getColor()
        {
            return this.color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public Boolean isFilled()
        {
            return this.filled;
        }
        public void setFilled(Boolean filled)
        {
            this.filled = filled;
        }
        public abstract double getArea();
        public abstract double getPerimeter();
        public abstract string toString();
    }
}

