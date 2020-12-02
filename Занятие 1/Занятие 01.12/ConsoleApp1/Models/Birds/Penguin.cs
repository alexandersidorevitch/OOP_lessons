using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Penguin : Bird, ISwimable
    {
        public Penguin(int maxAge, double averageWeight, double wingspan) : base(maxAge, averageWeight, wingspan) { }
        public void Swim()
        {
            Console.WriteLine("Ооо, рыбка плывёт. И акула...");
        }
    }
}
