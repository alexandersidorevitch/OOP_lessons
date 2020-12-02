using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Chicken : Bird
    {
        public Chicken(int maxAge, double averageWeight, double wingspan) : base(maxAge, averageWeight, wingspan) { }
    }
}
