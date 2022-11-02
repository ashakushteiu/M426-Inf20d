using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Tests
{
    public class AverageTest
    {
        [Fact]
        public void TestMeanOfTwoNumbers()
        {
            List<int> numbers = new List<int> { 5, 3 };
            double expected = 4;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfFiveNumbers()
        {
            List<int> numbers = new List<int> { 5, 3, 4, 5, 6 };
            double expected = 4.6;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfZero()
        {
            List<int> numbers = new List<int> { };
            Average average = new Average();

            Assert.Throws<DivideByZeroException>(() => average.Mean(numbers));
        }
    }
}
