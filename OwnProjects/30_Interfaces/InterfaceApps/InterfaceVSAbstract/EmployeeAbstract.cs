using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVSAbstract
{
    public abstract class EmployeeAbstract
    {
        // Does not support multiple inheritance
        // Can Have constructors

        // When to use : Abstract class is a good choice when you are sure some Methods are concrete/defined and must ve implement in the SAME WAY in all derived classes.

        public abstract void Project();
        public void Role()
        {
            Console.WriteLine("Engineer");
        }
    }
}
