using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    internal class RemoteControlCarCommunity
    {
        public int Speed { get; }
        public int BatteryDrain { get; }
        private int battery;
        private int distance;
        public RemoteControlCarCommunity(int speed, int batteryDrain)
        {
            battery = 100;
            distance = 0;
            Speed = speed;
            BatteryDrain = batteryDrain;
        }
        public bool BatteryDrained()
        {
            return (this.battery - BatteryDrain) < 0;
        }
        public int DistanceDriven()
        {
            return this.distance;
        }
        public void Drive()
        {
            if (!BatteryDrained())
            {
                this.distance += Speed;
                this.battery -= BatteryDrain;
            }
        }
        public static RemoteControlCarCommunity Nitro()
        {
            return new RemoteControlCarCommunity(50, 4);
        }
    }
}
