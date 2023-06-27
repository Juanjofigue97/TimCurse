using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloUser
{
    public static class UserInteraction
    {
        public static void AppStartMessage() 
        {
            Console.WriteLine("Hello, in this program, I'm using methods. \nThis application was created by Juan Jose Figueroa.");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
        }
        public static string AskUserName()
        {
            Console.Write("What is your first name: ");
            string nameUser = Console.ReadLine();
            return nameUser;
        }
        public static void HelloUser(string nameUser) 
        {
            Console.WriteLine($"Hello {nameUser} !");
        }  

        public static void SayGoodBye()
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Thank you for using this program. See you next time!");
            Console.WriteLine();
        }
    }
}
