using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMultiples
{
    public static class SumOfMultiples
    {
        public static int Sum(IEnumerable<int> multiples, int max)
        {
            List<int> allMultiples = new();

            foreach (int multiple in multiples)
            {
                var watcher = multiple;

                bool isLimited = false;
                int count = 0;
                while (!isLimited)
                {
                    count++;
                    if (count > 10000)
                    {
                        isLimited = true;
                    }
                    if (watcher >= max)
                    {
                        isLimited = true;
                        break;
                    }
                    allMultiples.Add(watcher);
                    watcher += multiple;
                }
            }
            Console.WriteLine(string.Join(',', allMultiples));
            return allMultiples.Distinct().Sum();
        }
    }
}
