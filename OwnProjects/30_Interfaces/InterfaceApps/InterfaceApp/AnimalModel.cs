using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    internal class AnimalModel : IRun
    {
        public string Name => "Animal";

        public void Run()
        {
            Console.WriteLine($"Running {Name}"); ;
        }
    }
}
