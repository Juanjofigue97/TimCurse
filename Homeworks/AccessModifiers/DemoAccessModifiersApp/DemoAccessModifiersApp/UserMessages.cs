using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAccessModifiersApp
{
    public class UserMessages : JobPositionModel
    {
        public void SayHello() 
        {
            var job = new JobPositionModel();
            Description = "Hello";
        }
    }
}
