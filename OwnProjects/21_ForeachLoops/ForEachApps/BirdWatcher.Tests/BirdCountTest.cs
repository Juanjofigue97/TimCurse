using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BirdWatcher;

namespace BirdWatcher.Tests
{
    public class BirdCountTest
    {
        // Check what the counts were last week
        [Fact]
        public void CheckCounts()
        {
            //BirdCount birdCount = new BirdCount();

            // Arrange
            int[] expected = new int[] { 0, 2, 5, 3, 7, 8, 4 };
            // Act
            var actual = BirdCount.LastWeek();
            //Assert
            Assert.Equal(expected, actual);
        }

        // Check how many birds visited today
        [Theory]
        [InlineData(new int[] { 0, 0, 1, 0, 0, 1, 0 })]
        public void FewBirdsVisitedToday(int[] counts)
        {
            var birdCount = new BirdCount(counts);

            Assert.Equal(0, birdCount.Today());
        }
        [Theory]
        [InlineData(new int[] { 8, 8, 9, 5, 4, 7, 10 })]
        public void ManyBirdsVisitedToday(int[] counts)
        {
            var birdCount = new BirdCount(counts);

            Assert.Equal(10, birdCount.Today());
        }

        // Increment today's count
        [Fact]
        public void IncrementCount()
        {
            var count = new int[] { 0, 0, 0, 4, 2, 3, 0 };
            BirdCount bird = new BirdCount(count);
            
            var expected = 1;
            bird.IncrementTodaysCount();
            var actual = bird.Today();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void IncrementCountWithPreviousVisits()
        {
            var count = new int[] { 8, 8, 5, 6, 8, 9, 4 };
            BirdCount bird = new BirdCount(count);

            var expected = 5;
            bird.IncrementTodaysCount();
            var actual = bird.Today();
            Assert.Equal(expected, actual);
        }

        // Check if there was a day with no visiting birds

        [Fact]
        public void HasDayWithoutBirds()
        {
            var counts = new int[] { 5,5,4,0,7,6,7 };
            var birdCount = new BirdCount(counts);

            var expected = true;
            var actual = birdCount.HasDayWithoutBirds();

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void HasDayWithoutBirdsNoDayWithoutBirds()
        {
            var counts = new int[] { 5, 5, 4, 1, 7, 6, 3 };
            var birdCount = new BirdCount(counts);

            var expected = false;
            var actual = birdCount.HasDayWithoutBirds();

            Assert.Equal(expected, actual);
        }

        // Calculate the number of visiting birds for the first number of days

        [Fact]
        public void CountFirstThreeDays()
        {
            var counts = new int[] { 0, 0, 1, 0, 0, 1, 0 };
            var birdCount = new BirdCount(counts);

            var expected = 1;
            var actual = birdCount.CountForFirstDays(3);
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void CountFirstSixDays()
        {
            var counts = new int[] { 5, 9, 12, 6, 8, 8, 17 };
            var birdCount = new BirdCount(counts);

            var expected = 48;
            var actual = birdCount.CountForFirstDays(6);
            Assert.Equal(expected, actual);
        }

        // Calculate the number of busy days
        [Fact]
        public void BusyDaysDisappointingWeek()
        {
            var counts = new int[] { 1, 1, 1, 0, 0, 0, 0 };
            var birdCount = new BirdCount(counts);
            Assert.Equal(0, birdCount.BusyDays());
        }
        [Fact]
        public void BusyDaysBusyWeek()
        {
            var counts = new int[] { 4, 9, 5, 7, 8, 8, 2 };
            var birdCount = new BirdCount(counts);
            Assert.Equal(5, birdCount.BusyDays());
        }

    }
}
