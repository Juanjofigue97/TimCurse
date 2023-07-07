using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaceInheritance
{
    internal class DBConnect : ILog
    {
        public void DoInform()
        {
            Console.WriteLine("This is DBConnect class");
        }

        public void GetVersion()
        {
            Console.WriteLine("Version 1.02");
        }

        public void DoLog()
        {
            Console.WriteLine("Logging");
        }

        public void Connect()
        {
            Console.WriteLine("Connecting to the database");
        }
    }
}
