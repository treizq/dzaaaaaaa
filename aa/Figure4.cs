using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Figure4
    {
        //площадь квадрата
        public double CalculateArea(double a)
        {
            return Math.Pow(a, 2);
        }

        //площадь прямоугольника
        public double CalculateArea(double a, double b)
        {
            return a * b;
        }

        //площадь прямоугольного треугольника
        public double CalculateArea(double a, double b, bool isTriangle)
        {
            return a * b / 2;
        }

        //площадь трапеции
        public double CalculateArea(double a, double b, double h)
        {
            return (a + b) * h / 2;
        }
    }
}
