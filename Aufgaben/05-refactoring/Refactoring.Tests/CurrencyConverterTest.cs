using Xunit;

namespace Refactoring.Tests;

public class CurrencyConverterTest
{
    [Fact]
    public void ConvertTo_getCorrectDollarPrice()
    {
        CurrencyConverter currencyConverter = new CurrencyConverter("USD");
        // Arrange
        double amount = 1.00;
        double expected = 1.09;

        // Act
        double actual = currencyConverter.ConvertTo(amount);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ConvertTo_getCorrectEuroPrice()
    {
        CurrencyConverter currencyConverter = new CurrencyConverter("EUR");
        // Arrange
        double amount = 1.00;
        double expected = 0.96;

        // Act
        double actual = currencyConverter.ConvertTo(amount);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ConvertTo_getCorrectPoundPrice()
    {
        CurrencyConverter currencyConverter = new CurrencyConverter("GBP");
        // Arrange
        double amount = 1.00;
        double expected = 0.82;

        // Act
        double actual = currencyConverter.ConvertTo(amount);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ConvertTo_getCorrectRubPrice()
    {
        CurrencyConverter currencyConverter = new CurrencyConverter("RUB");
        // Arrange
        double amount = 1.00;
        double expected = 79.78;

        // Act
        double actual = currencyConverter.ConvertTo(amount);

        // Assert
        Assert.Equal(expected, actual);
    }
}