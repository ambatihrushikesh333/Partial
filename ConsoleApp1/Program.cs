using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paetial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s=new Student();
            s.Id = 1;
            s.Name = "John";
            s.age   = 20;
            s.GetStudent();
            s.Marks1 = 85;
            s.Marks2 = 90;
            s.Marks3 = 78;
            s.TotalMarks();
            s.CalculateAverage();
        }
    }
}
