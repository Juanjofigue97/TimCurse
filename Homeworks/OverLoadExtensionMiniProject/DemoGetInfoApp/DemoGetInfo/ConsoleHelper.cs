using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGetInfo
{
    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output = "";
            Console.WriteLine(message);
            output = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(output))
            {
                Console.WriteLine("Please Enter a valid entry");
                output = Console.ReadLine();
            }
            return output;
        }
        public static decimal RequestDecimal(this string message)
        {
            return message.RequestDecimal(false);

        }
        public static decimal RequestDecimal(this string message, decimal minValue, decimal maxValue)
        {
            return message.RequestDecimal(true,minValue,maxValue);
        }

        private static decimal RequestDecimal(this string message,bool useMinMax, decimal minValue = 0,decimal maxValue = 0)
        {
            decimal output = 0;
            bool isValidInt = false;
            bool isInValidRange = true;

            while (isValidInt == false || isInValidRange == false)
            {
                Console.Write(message);
                isValidInt = decimal.TryParse(Console.ReadLine(), out output);

                if (useMinMax == true)
                {
                    isInValidRange = (output >= minValue && output <= maxValue);
                    //if (output >= minValue && output <= maxValue)
                    //{
                    //    isInValidRange = true;
                    //}
                    //else
                    //{
                    //    isInValidRange = false;
                    //}
                }
            }

            return output;
        }
    }
}
