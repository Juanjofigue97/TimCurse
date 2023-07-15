using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrringVsOverloading
{
    public abstract class BaseClass
    {
        public virtual void Greetings()
        {
            Console.WriteLine("Hello BaseClass");
        }

    }
}
