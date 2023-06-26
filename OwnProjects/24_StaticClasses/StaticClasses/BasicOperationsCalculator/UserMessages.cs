using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BasicOperationsCalculator
{
    public static class UserMessages
    {
        public static void ApplicationStartMessage(string firstName)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the Static Class Demo App");

            int hourDay = DateTime.Now.Hour;

            var output = hourDay switch
            {
                < 12 => $"Good morning { firstName }!",
                < 19 => $"Good afternoon {firstName}!",
                _ => $"Good evening  {firstName} !"
            };

            Console.WriteLine(output);
        }

        public static void PrintResultMessage(string message) 
        {
            Console.WriteLine(message);
            Console.WriteLine("--------------------------------");
        }
        public static void ApplicacionFinishMessage()
        {
            Console.WriteLine("Thank four using our app to calculate for you");

        }
    }
}