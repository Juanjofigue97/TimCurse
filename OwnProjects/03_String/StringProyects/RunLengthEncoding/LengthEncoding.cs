using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunLengthEncoding
{
    public static class LengthEncoding
    {
        public static string Encode(string input)
        {
            string encode = string.Empty;
            int counter = 1;
            for (int i = 0; i<input.Length-1;i++)
            {
                if (input[i] == input[input.Length])
                {

                }
                else if (input[i] == input[i + 1])
                {
                    counter++;
                }
                else
                {
                    encode += counter.ToString() + input[i];
                    counter = 1;
                }
            }
            return encode;
        }

        public static string Decode(string input)
        {
            string decode = string.Empty;
            int pointer = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                string Number = input[i].ToString();
                bool isValidNumber = int.TryParse(Number,out int number);

                if (!isValidNumber)
                {
                    Console.WriteLine(number);
                }

            }
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}
