using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proverb
{
    internal class ProverbCommunity
    {
        public static string[] Recite(string[] subjects)
        {
            if (subjects.Length == 0)
                return Array.Empty<string>();
            return subjects.Zip(subjects.Skip(1))
                .Select((pair => $"For want of a {pair.First} the {pair.Second} was lost."))
                .Append($"And all for the want of a {subjects.First()}.")
                .ToArray();
        }
    }
}
