using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    internal class CellPhone: IDevice, IVolumen, IPluggable
    {
        public void SwitchOn()
        {
            Console.WriteLine("Switching on");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Switching on");
        }

        public void VolumeUp()
        {
            Console.WriteLine("Volume up");
        }

        public void VolumeDown()
        {
            Console.WriteLine("Volume down");
        }

        public void PlugIn()
        {
            Console.WriteLine("Plugging In");
        }

        public void PlugOff()
        {
            Console.WriteLine("Plugging Off");
        }
    }
}
