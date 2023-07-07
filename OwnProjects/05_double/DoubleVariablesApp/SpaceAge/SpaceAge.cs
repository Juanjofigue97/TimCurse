using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceAge
{

    public class SpaceAge
    {
        public int Seconds { get; set; }
        private double EarthSecond = 31557600d;
        public SpaceAge(int seconds)
        {
            Seconds = seconds;
        }
        public double OnEarth()
        {
            return 1 * Seconds / EarthSecond;
        }
        public double OnMercury()
        {
            return Seconds / (EarthSecond * 0.2408467);
        }
        public double OnVenus()
        {
            return Seconds / (EarthSecond * 0.61519726);
        }
        public double OnMars()
        {
            return Seconds / (EarthSecond * 1.8808158);
        }
        public double OnJupiter()
        {
            return Seconds / (EarthSecond * 11.862615);
        }
        public double OnSaturn()
        {
            return Seconds / (EarthSecond * 29.447498);
        }
        public double OnUranus()
        {
            return Seconds / (EarthSecond * 84.016846);
        }
        public double OnNeptune()
        {
            return Seconds / (EarthSecond * 164.79132);
        }
    }
}
