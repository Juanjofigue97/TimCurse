using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideVsNew
{
    public class Base
    {
        public virtual void Info()
        {
            Console.WriteLine("Base class");
        }

        public virtual void Info2()
        {
            Console.WriteLine("Base class");
        }
    }
}
