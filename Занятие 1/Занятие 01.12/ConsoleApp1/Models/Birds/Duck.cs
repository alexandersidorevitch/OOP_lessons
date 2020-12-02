using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Duck : Bird, ISwimable, IFlyable
    {
        public Duck(int maxAge, double averageWeight, double wingspan) : base(maxAge, averageWeight, wingspan) { }
        public void Fly()
        {
            Console.WriteLine("Виу, я лечу");
        }
        public void Swim()
        {
            Console.WriteLine("Я уточка, я плаваю");
        }
    }
}
