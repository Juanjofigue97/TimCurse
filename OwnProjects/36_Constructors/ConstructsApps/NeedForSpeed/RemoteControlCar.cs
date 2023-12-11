using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class RemoteControlCar
    {
        // TODO: define the constructor for the 'RemoteControlCar' class
        public int speed;
        public int batteryDrain;
        private int distance;
        private int battery;
        public RemoteControlCar(int speed, int batteryDrain)
        {
            this.speed = speed;
            this.batteryDrain = batteryDrain;
            this.battery = 100;
        }

        public bool BatteryDrained()
        {
            if (battery - batteryDrain >= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int DistanceDriven()
        {
            return distance;
        }

        public void Drive()
        {
            if(battery>=0 && (battery - batteryDrain >= 0))
            {
                distance += speed;
                battery -= batteryDrain;
            }
        }

        public static RemoteControlCar Nitro()
        {
            return new RemoteControlCar(50,4);
        }
    }
}
