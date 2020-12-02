using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Eagle : Bird, IFlyable
    {
        public Eagle(int maxAge, double averageWeight, double wingspan) : base(maxAge, averageWeight, wingspan) { }
        public void Fly()
        {
            Console.WriteLine("Я орёл, я лечу высоко, высоко");
        }
    }
}
