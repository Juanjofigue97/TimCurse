
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class RaceTrack
    {
        // TODO: define the constructor for the 'RaceTrack' class
        private int distance;
        public RaceTrack(int distance)
        {
            this.distance = distance;
        }


        public bool TryFinishTrack(RemoteControlCar car)
        {

            int distanceCar = car.speed * (100 / car.batteryDrain);
            if (distanceCar >= distance)
            {
                return true;
            }
            else
            {
                return false;
            };
        }
    }
}
