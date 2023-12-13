using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemoLibraryAzure
{
    public class Messages : IMessages
    {
        public string SayHello() => "Hello Viewer";

        public string SayGoodbye() => "Goodbye, farewell, and good day!";
    }
}
