using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperationsCalculator
{
    public static class CalculateData
    {
        public static double Add(double x, double y)
        {
            double output = x + y;
            return output;
        }
        public static double Subtract(double x, double y)
        {
            double output = x - y;
            return output;
        }
        public static double Multiply(double x, double y)
        {
            double output = x * y;
            return output;
        }
        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return double.NaN;
            }

            double output = x / y;
            return output;
        }
    }
}
