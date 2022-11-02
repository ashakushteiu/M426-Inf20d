using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoPIsFive()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            // Given
            int a = 6;
            int b = 4;
            int expected = 2;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplication()
        {
            // Given
            int a = 6;
            int b = 4;
            int expected = 24;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Multiply(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivision()
        {
            // Given
            int a = 24;
            int b = 4;
            int expected = 6;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Division(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivisionDevideByZero()
        {
            // Given
            int a = 24;
            int b = 0;
            Calculator calculator = new Calculator();

            // When

            // Then
            Assert.Throws<DivideByZeroException>(() => calculator.Division(a, b));
        }
    }
}
