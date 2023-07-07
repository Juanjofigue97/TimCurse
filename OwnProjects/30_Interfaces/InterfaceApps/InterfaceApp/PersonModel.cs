using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    internal class PersonModel : IRun
    {
        public string Name => "Person";

        public void Run()
        {
            Console.WriteLine($"Running { Name }"); ;
        }
    }
}
