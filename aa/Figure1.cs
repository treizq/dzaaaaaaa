using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Figure1
    {
        //объема цилиндра
        public double CalculateVolume(double r, double h)
        {
            return Math.PI * Math.Pow(r, 2) * h;
        }

        //объема шара
        public double CalculateVolume(double r)
        {
            return (4.0 / 3) * Math.PI * Math.Pow(r, 3);
        }
    }
}
