using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    internal class RaceTrackCommunity
    {
        private readonly int distance;
        public RaceTrackCommunity(int distance)
        {
            this.distance = distance;
        }
        public bool TryFinishTrack(RemoteControlCarCommunity car)
        {
            int drives = (100 / car.BatteryDrain);
            int possibleDistance = drives * car.Speed;
            return (possibleDistance >= this.distance);
        }
    }
}
