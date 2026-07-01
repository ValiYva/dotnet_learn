using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Calculator
    {
        public double CalcTriangleSquare(double a, double h)
        {
            return 0.5 * a * h;
        }

        public double CalcTriangleSquare(double ab, double bc, double ac)
        {
            double p = (ab + bc + ac) / 2;

            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
            
        }
    }
}
