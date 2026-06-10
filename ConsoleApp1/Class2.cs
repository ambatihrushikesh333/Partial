using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Student
    {
        public int Marks1;
        public int Marks2;
        public int Marks3;

        public void TotalMarks()
        {
            int total = Marks1 + Marks2 + Marks3;
            Console.WriteLine("Total Marks: " + total);
        }
        public void CalculateAverage()
        {
            double avg = (Marks1 + Marks2 + Marks3) / 3.0;
            Console.WriteLine("Average: " + avg);
        }
    }

    internal class Class2
    {
    }
}
