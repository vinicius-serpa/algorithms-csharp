using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    class RootSquare
    {
        public static double MyRootSquare(int number)
        {
            int x = number;
            double s = 0.000;
            double e = (double)x;

            double len = e - s;
            double precision = 0.0001;
            double m = x;

            while (len >= precision)
            {
                if ((m * m) > x)
                    e = m;
                else
                    s = m;

                m = (s + e) / 2;
                len = e - s;
            }

            return m;
        }

        public static double trunc(double value)
        {
            value *= 1000;
            value = Math.Truncate(value);
            value /= 1000;

            return value;
        }
    }
}
