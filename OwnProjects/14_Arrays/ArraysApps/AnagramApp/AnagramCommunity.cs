using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramApp
{
    public class AnagramCommunity
    {
        private readonly string baseWord;
        public AnagramCommunity(string baseWord)
        {
            this.baseWord = baseWord.ToLower();
        }
        public string[] FindAnagrams(string[] potentialMatches) =>
            potentialMatches
                .Where(s => isAnagram(s.ToLower()))
                .ToArray();
        private bool isAnagram(string candidate) =>
            candidate == baseWord ? false : (
                string.Concat(candidate.OrderBy(c => c)) == string.Concat(baseWord.OrderBy(c => c))
            );
    }
}
