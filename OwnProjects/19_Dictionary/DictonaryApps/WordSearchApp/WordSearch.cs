using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
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
                if (word == '\n')
                {
                    x++;
                    y = 1;
                }
                else
                {
                    Grid.Add ((x, y),word);
                    y++;
                }
            }
        }

        public Dictionary<string, ((int, int), (int, int))?> Search(string[] wordsToSearchFor)
        {
            Dictionary<string, ((int, int), (int, int))?> output = new();

            foreach (var word in wordsToSearchFor)
            {
                var letters = Grid.Where(x => x.Value == word[i]);
                if (letters?.Count() == 0)
                {
                    continue;
                }

                foreach (var options in letters)
                {
                    (int x, int y) = options.Key.Value;
                    for (int i = 0; i < word.Length; i++)
                    {
                        bool isValid = false;
                        while (!isValid)
                        {
                            var letter = word[i];
                            if (Grid.ContainsKey((x + 1, y)))
                            {
                                if (Grid[(x, y)] != letter)
                                {
                                    
                                }
                            }
                        }
                    }


                    Console.WriteLine(options);
                }
                
            
            };

            // (x + 1 , y) , (x - 1, y) , (x, y + gridNumber) , (x, y - gridNumber) ,
            // (x + 1 , y - gridNumber ) ,  (x + 1 , y + gridNumber )
            // (x - 1 , y - gridNumber ) ,  (x - 1 , y + gridNumber )
            (int,int) Rigth(int x,int y)
            {
                return (x + 1, y );
            }
            (int, int) Left(int x, int y)
            {
                return (x - 1, y);
            }

            bool SearchOptions(string word,int x_axis, int y_axis)
            {
                int i = 0;
                foreach (var letter in word)
                {
                    AllOptions(letter, x_axis, y_axis);
                }

                return false;
            }

            (bool,string) AllOptions(char letter ,int x_axis, int y_axis)
            {
                (x_axis, y_axis) = Rigth(x_axis, y_axis);
                if (Grid.ContainsKey((x_axis, y_axis)))
                {
                    if (Grid[(x_axis, y_axis)] == letter)
                    {
                        return (true, "Opcion");
                    }
                }

                (x_axis, y_axis) = Left(x_axis, y_axis);

                return (true, "Ninguna");
            }

            return output;
        }
    }
}
