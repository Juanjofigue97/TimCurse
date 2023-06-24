    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace BirdWatcher
{
    public class BirdCount
    {
        private int[] birdsPerDay;

        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }

        public static int[] LastWeek()
        {
            int[] lastWeek = new int[] { 0, 2, 5, 3, 7, 8, 4 };
            return lastWeek;
        }

        public int Today() => birdsPerDay[^1];

        public void IncrementTodaysCount() => birdsPerDay[^1]++;

        public bool HasDayWithoutBirds() => birdsPerDay.Contains(0);

        public int CountForFirstDays(int numberOfDays)
        {
            var list = birdsPerDay[..numberOfDays];
            return list.Sum();
        }

        public int BusyDays()
        {
            var buyDays = birdsPerDay.Where(day => day >= 5);
            return buyDays.Count();
        }
    }
}
