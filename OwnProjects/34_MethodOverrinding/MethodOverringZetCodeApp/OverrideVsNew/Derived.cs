using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideVsNew
{
    public class Derived : Base
    {
        public override void Info()
        {
            Console.WriteLine("Derived class");
        }

        public new void Info2()
        {
            Console.WriteLine("Derived class");
        }
    }
}
