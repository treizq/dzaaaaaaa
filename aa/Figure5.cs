using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Figure5
    {
        //периметр квадрата
        public double CalculatePerimeter(double a)
        {
            return 4 * a;
        }

        //периметр прямоугольника
        public double CalculatePerimeter(double a, double b)
        {
            return 2 * (a + b);
        }

        //периметр прямоугольного треугольника
        public double CalculatePerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        //периметр трапеции
        public double CalculatePerimeter1(double a, double b, double c)
        {
            return a + b + 2 * c;
        }
    }
}
