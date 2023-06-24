using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMultiples
{
    public static class SumOfMultiplesCommunity
    {
        public static int Sum(IEnumerable<int> multiples, int max)
        {
            return Enumerable.Range(0, max)
                    .Where(item => multiples.Any(item2 => (item2 != 0) && item % item2 == 0))
                    .Sum();
        }
        public static int Sum2(IEnumerable<int> multiples, int max)
        {
            return multiples
            .SelectMany(multiple => Enumerable.Range(1, max - 1)
            .Where(n => multiple != 0 && n % multiple == 0))
            .Distinct()
            .Sum();

        }
    }
}
