using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Figure3
    {
        //площадь поверхности цилиндра
        public double CalculateSurfaceArea(double r, double h)
        {
            return 2 * Math.PI * r * (r + h);
        }

        //площадь поверхности шара
        public double CalculateSurfaceArea(double r)
        {
            return 4 * Math.PI * Math.Pow(r, 2);
        }
    }
}
