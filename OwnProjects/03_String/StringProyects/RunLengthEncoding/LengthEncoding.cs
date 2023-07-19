using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RunLengthEncoding
{
    public static class LengthEncoding
    {
        public static string Encode(string input)
        {
            string output = string.Empty;
            if (input == string.Empty)
            {
                return output;
            }
            
            char comparer = input[0];
            int number = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != comparer)
                {
                    if (number > 1)
                    {
                        output +=$"{ number }{ comparer }";
                    }else
                    {
                        output += $"{comparer}";
                    }
                    number = 1;
                    comparer = input[i];
                    if (i == input.Length - 1)
                    {
                        output += $"{comparer}";
                    }
                }
                else
                {
                    number++;
                    if (i == input.Length-1)
                    {
                        output += $"{number}{comparer}";
                    }
                }
            }

            return output;    
        }



        public static string Decode(string input)
        {
            string output = "";
            int realnumber = 0;
            int index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                var letter = input[i];
                var trynumber  = input[index..(i+1)];
                var isValidNimber = int.TryParse(trynumber,out int number);

                if (number != 0)
                {
                    realnumber = number;
                }

                if (!isValidNimber || letter == ' ') 
                {
                    output += $"{letter}";
                    for (int j = 0; j < realnumber-1; j++)
                    {
                        output += $"{ letter }";
                    }
                    index = i + 1;
                    realnumber = 0;
                }
            }
            return output;
        }
    }
}
