using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Myclass
    {
        internal void Display<T>(T u)
        {
            Console.WriteLine(u);
        }
        internal void Add<T>(T a, T b)
        {
            Console.WriteLine("Value of A is: " + a);
            Console.WriteLine("Value of B is: " + b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Myclass obj = new Myclass();
            obj.Display<int>(100);
            obj.Display<string>("Hello");
            obj.Display<bool>(true);
            obj.Add<int>(100, 200);
            obj.Add<bool>(true, false);
            obj.Add<double>(12.5, 15.5);
            obj.Add<string>("Welcome", "to C#");
        }
    }
}
