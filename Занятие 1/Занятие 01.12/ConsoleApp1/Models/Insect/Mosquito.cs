using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Mosquito : LivingThingWithWings, IFlyable
    {
        public Mosquito(int maxAge, double averageWeight, double wingspan) : base(maxAge, averageWeight, wingspan) { }
        public void Fly()
        {
            Console.WriteLine("Пи-пи-пи");
        }
    }
}
