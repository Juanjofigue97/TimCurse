using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrabbleScore
{
    internal class ScrabbleScores
    {
        public static int Score(string input)
        {
            int score = 0;

            input = input.ToUpper();

            List<Char> valueone = new() { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' };
            List<Char> valuetwo = new() { 'D', 'G' };
            List<Char> valuethree = new() { 'B', 'C', 'M', 'P' };
            List<Char> valuefour = new() { 'F', 'H', 'V', 'W', 'Y' };
            List<Char> valuefive = new() { 'K' };
            List<Char> valueeight = new() { 'J', 'X' };
            List<Char> valueten = new() { 'Q', 'Z' };

            foreach (char c in input)
            {
                score += valueone.Contains(c) == true ? 1 : 0;
                score += valuetwo.Contains(c) == true ? 2 : 0;
                score += valuethree.Contains(c) == true ? 3 : 0;
                score += valuefour.Contains(c) == true ? 4 : 0;
                score += valuefive.Contains(c) == true ? 5 : 0;
                score += valueeight.Contains(c) == true ? 8 : 0;
                score += valueten.Contains(c) == true ? 10 : 0;
            }
            return score;
        }
    }
}
