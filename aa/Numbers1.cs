using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Numbers1
    {
        //произведение двух чисел типа uint
        public uint Multiply(uint a, uint b)
        {
            return a * b + 1;
        }

        //произведение двух чисел типа int
        public int Multiply(int a, int b)
        {
            return a * b + 2;
        }

        //произведение двух чисел типа long
        public long Multiply(long a, long b)
        {
            return a * b + 3;
        }

        //произведение двух чисел типа double
        public double Multiply(double a, double b)
        {
            return a * b + 0.1;
        }
    }
}
