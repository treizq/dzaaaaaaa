using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Arrays1
    {
        //нахождение максимального числа в массиве целых чисел
        public int FindMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        //нахождение максимального числа в массиве вещественных чисел
        public double FindMax(double[] numbers)
        {
            double max = numbers[0];
            foreach (double num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    }
}
