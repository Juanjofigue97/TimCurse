using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RunLengthEncoding
{
    public class LenghtEncodingCommunity
    {
        public static string Encode(string input) => Regex.Replace(input, @"(\D)\1+", m => m.Length.ToString() + m.Value[0]);

        public static string Decode(string input) => Regex.Replace(input, @"(\d+)(\D)", m => new String(m.Groups[2].Value[0], Int32.Parse(m.Groups[1].Value)));
    }
}
