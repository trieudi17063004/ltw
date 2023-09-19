using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    internal class Staff : Person
    {
        private string department;
        private double salary;

        public Staff() { }
        public Staff(string name, int birthYear, string address, string department, double salary) : base(name, birthYear, address)
        {
            this.department = department;
            this.salary = salary;
        }
        public override void input()
        {
            base.input();
            Console.Write("Nhap noi lam viec: ");
            department = Console.ReadLine();
            Console.Write("Nhap luong: ");
            salary = int.Parse(Console.ReadLine());
        }
        public override string toString()
        {
            return $"Staff[]{base.toString()} - Department:{department}, Salary:{salary}";
        }
        public void updateSalary(double salary)
        {
            this.salary = salary;
        }
    }
}

