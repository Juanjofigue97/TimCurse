using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearchApp
{
    public class WordSearch
    {
        public Dictionary<(int, int)? ,char> Grid { get; set; } = new Dictionary<(int, int)?, char>();
        public WordSearch(string grid)
        {
            
            int x = 1;
            int y = 1;
            foreach (var word in grid)
            {
                Console.WriteLine(word);
                Grid.Add ((x, y),word);
                y++;
            }
        }

        public Dictionary<string, ((int, int), (int, int))?> Search(string[] wordsToSearchFor)
        {
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}
