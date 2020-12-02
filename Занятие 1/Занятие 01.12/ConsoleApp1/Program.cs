using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var duck = new Duck(10, 12, 32);
            duck.Fly();
            duck.Swim();
            Console.WriteLine(duck);
            var eagle = new Eagle(12, 300, 100);
            eagle.Fly();
            Console.WriteLine(eagle);
        }
    }
}
