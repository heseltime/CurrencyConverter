namespace CurrencyConverter.Domain;

public class CurrencyData
{
	public CurrencyData(string symbol, string name, string? country, double euroRate)
	{
		Symbol = symbol;
		Name = name;
		Country = country;
		EuroRate = euroRate;
	}

	public string Symbol { get; set; }

	public string Name { get; set; }

	public string? Country { get; set; }

	public double EuroRate { get; set; }

	public override string ToString()
	{
		return String.Format($"{Name} ({Symbol}): euroRate={EuroRate}; country={Country}");
	}
}