using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР_1
{
    internal class Minus
    {
        public double res;

        public Minus(double x, double y)
        {
            res = Pls(x, y);
        }

        double Pls(double x, double y)
        { return Math.Round((x - y), 3); }
    }
}
