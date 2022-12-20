namespace Refactoring;

public class CurrencyConverter
{
    string ToCurrency { get; }

    public CurrencyConverter(string toCurrency)
    {
        this.ToCurrency = toCurrency;
    }

    public double ConvertTo(double amount)
    {
        if(ToCurrency.Equals("USD"))
        {
            return amount * 1.09;
        } 
        else if(ToCurrency.Equals("EUR"))
        {
            return amount * 0.96;
        }
        else if(ToCurrency.Equals("GBP"))
        {
            return amount * 0.82;
        }
        else if(ToCurrency.Equals("RUB"))
        {
            return amount * 79.78;
        }
        throw new ArgumentException($"no exchange rate for {ToCurrency} available");
    }
}