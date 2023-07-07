using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramApp
{
    public class Anagram
    {
        public string Word { get; set; }
        public Anagram(string baseWord)
        {
            Word = baseWord;
        }

        public string[] FindAnagrams(string[] potentialMatches)
        {
            List<char> chars = Word.ToLower().ToList();
            List<string> goodMatches = new ();

            foreach (var word in potentialMatches)
            {
                if (word.ToLower() == Word.ToLower())
                {
                    continue;
                }
                List<char> letters = word.ToLower().ToList();
                bool isAnagram = false;
                chars = Word.ToLower().ToList();
                foreach (var letter in letters) 
                {
                    if (chars.Contains(letter))
                    {
                        var index = chars.IndexOf(letter);
                        chars.RemoveAt(index);

                        if (chars.Count == 0)
                        {
                            isAnagram = true;
                        }
                    }
                    else
                    {
                        isAnagram = false;
                    }
                }
                if (isAnagram)
                {
                    goodMatches.Add(word);
                }

            }
            return goodMatches.ToArray();
        }
    }
}
