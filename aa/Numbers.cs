using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Numbers
    {
        //нахождение максимального из двух чисел
        public int FindMax(int a, int b)
        {
            return a > b ? a : b;
        }

        //нахождение максимального из трех чисел
        public int FindMax(int a, int b, int c)
        {
            return FindMax(FindMax(a, b), c);
        }

        //нахождение максимального из четырех чисел
        public int FindMax(int a, int b, int c, int d)
        {
            return FindMax(FindMax(a, b, c), d);
        }

        //нахождение максимального из пяти чисел
        public int FindMax(int a, int b, int c, int d, int e)
        {
            return FindMax(FindMax(a, b, c, d), e);
        }
    }
}
