using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationLibrary.MyTests
{
    public class CalculationLibraryTests
    {
        // Add Operations
        [Fact]
        public void AddNegativeNumbers()
        {
            double firstNumber = -4;
            double secondNumber = -3;

            Calculations calculations = new Calculations();

            var expected = -7;
            var actual = calculations.Add(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AddPositiveNumbers()
        {
            double firstNumber = 4;
            double secondNumber = 6;

            Calculations calculations = new Calculations();

            var expected = 10;
            var actual = calculations.Add(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AddOnePositiveNumberOneNegtive()
        {
            double firstNumber = -4;
            double secondNumber = 6;

            Calculations calculations = new Calculations();

            var expected = 2;
            var actual = calculations.Add(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }

        // Subtract Operations
        [Fact]
        public void SubtractNegativeNumbers()
        {
            double firstNumber = -4;
            double secondNumber = -3;

            Calculations calculations = new Calculations();

            var expected = -1;
            var actual = calculations.Subtract(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SubtractPositiveNumbers()
        {
            double firstNumber = 4;
            double secondNumber = 6;

            Calculations calculations = new Calculations();

            var expected = -2;
            var actual = calculations.Subtract(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SubtractOnePositiveNumberOneNegtive()
        {
            double firstNumber = -4;
            double secondNumber = 6;

            Calculations calculations = new Calculations();

            var expected = -10;
            var actual = calculations.Subtract(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }

        // Multiply Operations
        [Fact]
        public void MultiplyNegativeNumbers()
        {
            double firstNumber = -4;
            double secondNumber = -3;

            Calculations calculations = new Calculations();

            var expected = 12;
            var actual = calculations.Multiply(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void MultiplyPositiveNumbers()
        {
            double firstNumber = 4;
            double secondNumber = 6;

            Calculations calculations = new Calculations();

            var expected = 24;
            var actual = calculations.Multiply(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void MultiplyOnePositiveNumberOneNegtive()
        {
            double firstNumber = -4;
            double secondNumber = 6;

            Calculations calculations = new Calculations();

            var expected = -24;
            var actual = calculations.Multiply(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0,3.5)]
        [InlineData(0,-5.4)]
        [InlineData(0,0)]
        public void MultiplyWithZero(double firstNumber,double secondNumber)
        {
            Calculations calculations = new Calculations();

            var expected = firstNumber * secondNumber;
            var actual = calculations.Multiply(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }

        // Divide Operations

        [Fact]
        public void DivideTwoNegativeNumbers()
        {
            double firstNumber = -15;
            double secondNumber = -3;

            Calculations calculations = new Calculations();

            var expected = 5;
            var actual = calculations.Divide(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DividePositiveNumbers()
        {
            double firstNumber = 18;
            double secondNumber = 3;

            Calculations calculations = new Calculations();

            var expected = 6;
            var actual = calculations.Divide(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DivideOnePositiveNumberOneNegtive()
        {
            double firstNumber = 5;
            double secondNumber = 0.5;

            Calculations calculations = new Calculations();

            var expected = 10;
            var actual = calculations.Divide(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3.5,0)]
        [InlineData(-5.4,0)]
        [InlineData(0, 0)]
        public void DivideWithZero(double firstNumber, double secondNumber)
        {
            Calculations calculations = new Calculations();

            var expected = 0;
            var actual = calculations.Divide(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }

    }
}
