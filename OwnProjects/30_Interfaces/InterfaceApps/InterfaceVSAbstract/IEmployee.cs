using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVSAbstract
{
    // Only Method Declaration is Allowed
    // Does support multiple inheritance
    // Can't Have constructors

    // When to use : An interface is a good choice when you know a method has to be there, but it can be implemented DIFFERENTLY by independet derived classes.

    interface IEmployee
    {
        public void Project1();
        public void Manager1();
    }
}
