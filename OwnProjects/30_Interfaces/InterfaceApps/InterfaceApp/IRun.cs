using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    public interface IRun
    {
        public string Name { get; }
        public void Run();
    }
}
