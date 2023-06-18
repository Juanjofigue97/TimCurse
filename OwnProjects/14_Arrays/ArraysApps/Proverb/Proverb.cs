using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proverb
{
    public static class Proverb
    {
        public static string[] Recite(string[] subjects)
        {
            string[] allLines = new string[subjects.Length];
            if (subjects.Length == 0 )
                return allLines;
            allLines[subjects.Length-1] = $"And all for the want of a {subjects[0]}.";
            for (int i = 0; i < subjects.Length - 1; i++)
            {
                string line = $"For want of a {subjects[i]} the {subjects[i+1]} was lost.";
                allLines[i] = line;
            }
            return allLines;
        }
    }
}
