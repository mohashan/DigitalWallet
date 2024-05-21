namespace DigitalWallet.Features.MultiCurrency.Common;

public class CurrencyConverter
{
    public decimal Convert(Currency sourceCurrency, Currency destinationCurrency, decimal amount)
        => sourceCurrency.Ratio / destinationCurrency.Ratio * amount;
}
