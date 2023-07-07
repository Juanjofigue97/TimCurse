using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaceInheritance
{
    internal interface ILog : IInfo, IVersion
    {
        void DoLog();
    }
}
