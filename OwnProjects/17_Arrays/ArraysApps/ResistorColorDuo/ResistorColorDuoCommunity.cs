using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistorColorDuo
{
    internal class ResistorColorDuoCommunity
    {
        public static int Value(string[] colors)
        {
            var value1 = GetColorValue(colors[0]) * 10;
            var value2 = GetColorValue(colors[1]);
            return value1 + value2;
        }
        private static int GetColorValue(string color) => (color.ToLower()) switch
        {
            "black" => 0,
            "brown" => 1,
            "red" => 2,
            "orange" => 3,
            "yellow" => 4,
            "green" => 5,
            "blue" => 6,
            "violet" => 7,
            "grey" => 8,
            "white" => 9,
            _ => -1,
        };
    }
}
