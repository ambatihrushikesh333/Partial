using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultipleMedia multimedia = new MultipleMedia();
            multimedia.Display();
            multimedia.PlayAudio();
            multimedia.PlayVideo();
            Console.ReadLine();
        }
    }
}
