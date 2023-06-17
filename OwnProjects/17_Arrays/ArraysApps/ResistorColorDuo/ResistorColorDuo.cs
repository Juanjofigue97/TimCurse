using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistorColorDuo
{
    public static class ResistorColorDuo
    {
        private static readonly string[] ColorsArray =
       {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
        public static int Value(string[] colors)
        {
            string codeColor = "";
            for (int i = 0; i <= 1; i++)
            {
                codeColor += Array.IndexOf(ColorsArray, colors[i].ToLower());
            }
            return int.Parse(codeColor);
        }
    }
}
