using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    internal class Student : Person
    {
        private string program;
        private int year;

        public Student() { }
        public Student(string name, int birthYear, string address, string program, int year) : base(name, birthYear, address)
        {
            this.program = program;
            this.year = year;
        }
        public override void input()
        {
            base.input();
            Console.Write("Nhap mon hoc: ");
            program = Console.ReadLine();
            Console.Write("Ban hoc nam may: ");
            year = int.Parse(Console.ReadLine());
        }
        public override string toString()
        {
            return $"Student[{base.toString()} - Program:{program}, Year:{year}]";
        }
        public void changeProgram(string program)
        {
            this.program = program;
        }
    }
}
