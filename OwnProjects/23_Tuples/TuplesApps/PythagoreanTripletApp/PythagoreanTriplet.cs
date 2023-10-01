using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PythagoreanTripletApp
{
    public static class PythagoreanTriplet
    {
        public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
        {
            List<(int,int,int)> output = new List<(int,int,int)>();
            for (int c = 3; c < sum - 3; c++)
            {
                double first = Math.Pow(c - sum,2);
                double second = (Math.Pow(sum-c,2) - Math.Pow(c,2))/2;
                //Console.WriteLine($"{c}: { first + second }");

                if (first + second < 0)
                {
                    break;
                }

                double parameterA = 1;
                double parameterB = c-sum;
                double parameterC = second;

                double Discriminant = (Math.Pow(parameterB, 2) - 4 * parameterA * parameterC);

                if (Discriminant > 0)
                {
                    double firstSolution = (-parameterB - Math.Sqrt(Discriminant)) / (2 * parameterA);
                    double SecondSolution = (-parameterB + Math.Sqrt(Discriminant)) / (2 * parameterA);

                    bool validInt = int.TryParse(firstSolution.ToString(),out int firstSolutionR);

                    if (!validInt)
                    {
                        continue;
                    }

                    //Console.WriteLine($"{c}: x1 { firstSolution }, x2 = {SecondSolution}");

                    if (firstSolution == 0)
                    {
                        break;
                    }

                    if (firstSolution + SecondSolution + c == sum && firstSolution > 0 && SecondSolution > 0 && (Math.Pow(firstSolution,2)+ Math.Pow(SecondSolution, 2) == Math.Pow(c, 2)))
                    {
                        var rigthCombination = (Convert.ToInt32(firstSolution), Convert.ToInt32(SecondSolution), Convert.ToInt32(c));
                        output.Add(rigthCombination);
                    }

                }
            }
            output = output.OrderBy(numbers => numbers.Item1).ToList();
            return output;
        }
    }
}
