using System;
using System.Collections.Generic;
using System.Net.Http;

namespace CsCbArbitrage
{
    public interface ICoinbaseService
    {
        List<Currency> GetCurrencies();
    }

    public class CoinbaseService : ICoinbaseService
    {
        /// <summary>
        /// Gets list of currencies available on Coinbase exchange.
        /// </summary>
        public List<Currency> GetCurrencies()
        {
            var apiUrl = "https://api.coinbase.com/v2/exchange-rates?currency=AUD";

            var client = new HttpClient();

            var result = client.GetStringAsync(apiUrl).Result;

            Console.WriteLine(result);

            return new List<Currency>();
        }
    }
}