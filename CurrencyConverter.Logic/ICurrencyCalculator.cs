﻿using CurrencyConverter.Domain;

namespace CurrencyConverter.Logic;

public interface ICurrencyCalculator
{
	Task<double> RateOfExchangeAsnyc(string srcCurr, string targCurr);
	Task<CurrencyData> GetCurrencyDataAsync(string currSymbol);
	Task<IEnumerable<string>> GetCurrenciesAsync();
	Task<bool> CurrencyExistsAsync(string currSymbol);
	Task InsertAsnyc(CurrencyData data);
	Task UpdateAsync(CurrencyData data);
	Task DeleteAsync(string symbol);
}
