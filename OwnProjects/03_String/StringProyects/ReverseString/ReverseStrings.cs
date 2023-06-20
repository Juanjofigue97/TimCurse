using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public static class ReverseStrings
    {
        public static string Reverse(string input)
        {
            string reverseWord = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverseWord += input[i];
            }
            return reverseWord;
        }
        public static string Reverse2(string input)
        {
            var reverseWord = new String(input.Reverse().ToArray());
            return reverseWord;
        }
    }
}
