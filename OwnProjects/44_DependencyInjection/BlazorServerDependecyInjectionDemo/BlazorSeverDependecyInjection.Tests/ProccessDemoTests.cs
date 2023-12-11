
using BlazorServerDependecyInjection.Data;

namespace BlazorSeverDependecyInjection.Tests
{
    public class ProccessDemoTests
    {
        [Fact]
        public void GetDaysInMonth_ShouldReturnProperNumberForLeapYear()
        {
            TestingDemo t = new(DateTime.Parse("2/1/2000"));       
            ProcessDemo p = new(t);

            int expected = 29;
            int actual = p.GetDaysInMonth();

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetDaysInMonth_ShouldReturnProperNumberForNonLeapYear()
        {
            TestingDemo t = new(DateTime.Parse("2/1/2001"));
            ProcessDemo p = new(t);

            int expected = 28;
            int actual = p.GetDaysInMonth();

            Assert.Equal(expected, actual);
        }


    }
    public class TestingDemo : IDemo
    {
        public DateTime StartupTime { get; set ; }

        public TestingDemo(DateTime startTime)
        {
            StartupTime = startTime;
        }

    }
}