using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistorColorApp
{
    internal class ResistorColor
    {
        
        public static int ColorCode(string color)
        {
            string[] listColors = new string[] 
            {
                "Black",
                "Brown",
                "Red",
                "Orange",
                "Yellow",
                "Green",
                "Blue",
                "Violet",
                "Grey",
                "White"
            };

            for (int i = 0; i <= listColors.Length - 1; i++)
            {
                if (listColors[i].ToUpper() == color.ToUpper())
                {
                    return i;
                }
            }
            return -1;
        }

        public static string[] Colors()
        {
            string[] bandColors = new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
             return bandColors;
        }
    }
}


