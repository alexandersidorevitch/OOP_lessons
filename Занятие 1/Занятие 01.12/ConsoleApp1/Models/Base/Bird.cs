using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Bird : LivingThingWithWings
    {
        public Bird(int maxAge, double averageWeight, double wingspan) : base(maxAge, averageWeight, wingspan) { }

    }
}
