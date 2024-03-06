using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyLibrary
{
    public class DemoDependecy2 : IDemoDependecy
    {
        public string GiveRandomNumber()
        {
            return $"This is our not-working randon value : ";
        }
    }
}
