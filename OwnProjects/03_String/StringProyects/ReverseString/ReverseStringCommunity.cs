using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal static class ReverseStringCommunity
    {
        public static string Reverse(string input)
        {
            var builder = new StringBuilder();
            foreach (char c in input)
            {
                builder.Insert(0, c);
            }
            return builder.ToString();
        }
    }
}
