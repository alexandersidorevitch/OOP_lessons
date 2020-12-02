using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class LivingThingWithWings : LivingThing
    {
        private double wingspan;
        public double Wingspan
        {
            get { return wingspan; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Длина крыльев не может быть отрицательной");
                }
                wingspan = value;
            }
        }
        public LivingThingWithWings(int maxAge, double averageWeight, double wingspan) : base(maxAge, averageWeight)
        {
            Wingspan = wingspan;
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nРазмах крыльев: {wingspan} см";
        }
    }
}
