using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Figure
    {
        //объема куба
        public double CalculateVolume(double a)
        {
            return Math.Pow(a, 3);
        }

        //объема прямоугольного параллелепипеда
        public double CalculateVolume(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
