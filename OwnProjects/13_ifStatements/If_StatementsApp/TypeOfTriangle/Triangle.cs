using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeOfTriangle
{
    internal class Triangle
    {
        public static bool IsTriangle(double side1, double side2, double side3)
        {
            if (side1 == 0 || side2 == 0 || side3 == 0)
            {
                return false;
            }

            bool caso1 = side1 + side2 >= side3 ? true : false;
            bool caso2 = side2 + side3 >= side1 ? true : false;
            bool caso3 = side1 + side3 >= side2 ? true : false;
            if (caso1 && caso2 && caso3)
            {
                return true;
            }
            else
            {
                return false;
            };
        }
        public static bool IsScalene(double side1, double side2, double side3)
        {
            if (IsTriangle(side1, side2, side3))
            {
                if (side1 != side2 && side1 != side3 && side2 != side3)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        public static bool IsIsosceles(double side1, double side2, double side3)
        {
            if (IsTriangle(side1, side2, side3))
            {
                if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public static bool IsEquilateral(double side1, double side2, double side3)
        {
            if (IsTriangle(side1, side2, side3))
            {
                if (side1 == side2 && side1 == side3 && side2 == side3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
}
