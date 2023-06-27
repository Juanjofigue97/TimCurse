using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplesApp
{
    public static class MathShortcuts
    {
        public static (double add, double sub) BasicOperation(double x, double y)
        {
            double outputAdd = x + y;
            double outputSub = x - y;
            return (outputAdd, outputSub);
        }
    }
}
