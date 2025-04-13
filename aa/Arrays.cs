using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Arrays
    {
        //расчет среднего арифметического массива целых чисел
        public double CalculateAverage(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return (double)sum / numbers.Length;
        }

        //расчет среднего арифметического массива вещественных чисел
        public double CalculateAverage(double[] numbers)
        {
            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }
    }
}
