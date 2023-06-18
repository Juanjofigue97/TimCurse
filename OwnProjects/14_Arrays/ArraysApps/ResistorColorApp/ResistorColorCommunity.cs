using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistorColorApp
{
    public class ResistorColorCommunity
    {
        private static readonly string[] ColorsArray =
       {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
        public static int ColorCode(string color) =>
           Array.IndexOf(ColorsArray, color.ToLower());
        public static string[] Colors() => ColorsArray;
    }
}
