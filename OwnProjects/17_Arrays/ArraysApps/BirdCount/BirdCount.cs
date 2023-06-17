using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdCount
{
    internal class BirdCount
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

        public int Today()
        {
            return birdsPerDay[^1];
        }

        public void IncrementTodaysCount()
        {
            birdsPerDay[^1] += 1;
        }

        public bool HasDayWithoutBirds()
        {
            return birdsPerDay.Contains(0);
        }

        public int CountForFirstDays(int numberOfDays)
        {
            int counted = 0;
            for (int i = 0; i < numberOfDays; i++)
            {
                counted += birdsPerDay[i];
            }
            return counted;
        }

        public int BusyDays()
        {
            int buyDays = 0;
            for (int i = 0; i < birdsPerDay.Length - 1; i++)
            {
                if (birdsPerDay[i] >= 5)
                {
                    buyDays += 1;
                }
            };
            return buyDays;
        }
    }
}
