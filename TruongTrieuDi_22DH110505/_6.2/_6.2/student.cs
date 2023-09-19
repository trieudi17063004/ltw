using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    internal class Student
    {
        //attributer
        private string studentid;
        private string name;
        private int birthYear;
        private bool gender;
        private string stdClass;
        //Contructor
        public Student(string studentId, string name, int birthYear, bool gender, string stdClass)
        {
            this.studentid = studentId;
            this.name = name;
            if (birthYear >= 1900 && birthYear <= DateTime.Today.Year)
                this.birthYear = birthYear;
            else
                this.birthYear = 1900;
            this.gender = gender;
            this.stdClass = stdClass;
        }
        //methods
        public string GetstudentId() { return studentid; }
        public void SetStudentId(string newStudentId)
        {
            this.studentid = newStudentId;
        }
        public string GetName() { return name; }
        public void SetName(string newName)
        {
            this.name = newName;

        }
        public int GetBirthYear() { return birthYear; }
        public void SetBirthYear(int newbirthYear)
        {
            if (newbirthYear >= 1900 && newbirthYear <= DateTime.Today.Year)
                this.birthYear = newbirthYear;
            else
                this.birthYear = 1900;

        }
        public bool GetGender() { return gender; }
        public void SetGender(bool newGender)
        {
            this.gender = newGender;
        }
        public string GetStdClass() { return stdClass; }
        public void SetStdClass(string newStdClass)
        {
            this.stdClass = newStdClass;
        }
        public void Input()
        {
            Console.WriteLine("\n nhap thong tin sv");
            Console.Write("ma so sinh vien: ");
            studentid = Console.ReadLine();

            Console.Write("Ten sinh vien: ");
            name = Console.ReadLine();

            do
            {
                Console.Write("nam sinh cua sn : ");
                birthYear = int.Parse(Console.ReadLine());

            }
            while (birthYear < 1900 || birthYear > DateTime.Today.Year);

            Console.Write("Gioi Tinh(True/False): ");
            gender = bool.Parse(Console.ReadLine());

            Console.Write("SV lop : ");
            stdClass = Console.ReadLine();
        }
        public int GetAge()
        {
            return DateTime.Today.Year - birthYear;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {GetstudentId()}");
            Console.WriteLine($"Name: {GetName()}");
            Console.WriteLine($"Birth Year: {GetBirthYear()}");

            string sex = "Nu";
            if (GetGender())
                sex = "Nam";
            Console.WriteLine($"Gender: {sex}");
            Console.WriteLine($"Class: {GetStdClass()}");
        }

    }
}
