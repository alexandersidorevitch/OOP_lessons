using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class LivingThing
    {
        private int maxAge;
        public int MaxAge {
            get { return maxAge; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Возраст не может быть отрицательной");
                }
                maxAge = value;
            }
        }
        private double averageWeight;
        public double AverageWeight
        {
            get { return averageWeight; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Вес не может быть отрицательной");
                }
                averageWeight = value;
            }
        }

        public LivingThing(int maxAge, double averageWeight)
        {
            MaxAge = maxAge;
            AverageWeight = averageWeight;
        }
        public override string ToString()
        {
            return $"Максимальный возраст: {maxAge} лет\nСредний вес: {averageWeight} кг";
        }
    }
}
