using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР_1
{
    internal class Multiply
    {
        public double res;

        public Multiply(double x, double y)
        {
            res = Pls(x, y);
        }

        double Pls(double x, double y)
        { return Math.Round((x *y), 3); }
    }
}
