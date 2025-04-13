using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Figure2
    {
        //площадь поверхности куба
        public double CalculateSurfaceArea(double a)
        {
            return 6 * Math.Pow(a, 2);
        }

        //площадь поверхности прямоугольного параллелепипеда
        public double CalculateSurfaceArea(double a, double b, double c)
        {
            return 2 * (a * b + a * c + b * c);
        }
    }
}
