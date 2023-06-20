using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracksOnTracksOnTracks
{
    public static class Languages2
    {
        public static List<string> NewList() => new();

        public static List<string> GetExistingLanguages() => new() { "C#", "Clojure", "Elm" };

        public static List<string> AddLanguage(List<string> languages, string language) 
        {
            languages.Add(language);
            return languages;
        }

        public static int CountLanguages(List<string> languages) => languages.Count;

        public static bool HasLanguage(List<string> languages, string language) => languages.Contains(language);


        public static List<string> ReverseList(List<string> languages)
        {
            languages.Reverse();
            return languages;
        }

        public static bool IsExciting(List<string> languages)
        {
            if (languages.Count == 0) return false;
            if ((languages[0] == "C#" || languages[1] == "C#") && (languages.Count >= 1 && languages.Count <= 3))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<string> RemoveLanguage(List<string> languages, string language)
        {
            languages.Remove(language);
            return languages;
        }

        public static bool IsUnique(List<string> languages)
        {
            languages.Sort();
            for (int i = 0; i < languages.Count - 1; i++)
            {
                if (languages[i] == languages[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
