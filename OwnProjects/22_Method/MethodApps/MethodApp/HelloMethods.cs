using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodApp
{
    public static class HelloMethods
    { 
        public static void SayHello()
        {
            Console.WriteLine($"Hello User! Thank you for coming");
        }
        public static void SayHelloNameUser(string name)
        {
            Console.WriteLine($"Hello {name}! Thank you for coming");

        }
    }
}
