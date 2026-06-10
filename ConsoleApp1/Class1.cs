using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Student
    {
        public int Id;
        public string Name;
        public int age;
        public void GetStudent()
        {
            Console.WriteLine("Student ID: " + Id);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student Age: " + age);
            Console.WriteLine("=========================================");
        }
    }
    internal class Class1
    {
    }
}
