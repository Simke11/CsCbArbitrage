using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace CsCbArbitrage
{
    public interface ICoinbaseService
    {
        List<Currency> GetCurrencies();

        decimal GetPriceFromExchangeRate(decimal rate);
    }

    public class CoinbaseService : ICoinbaseService
    {
        /// <summary>
        /// Gets list of currencies available on Coinbase exchange.
        /// </summary>
        public List<Currency> GetCurrencies()
        {
            var currencies = new List<Currency>();

            // Call API
            var apiUrl = "https://api.coinbase.com/v2/exchange-rates?currency=AUD";
            var client = new HttpClient();
            var response = client.GetStringAsync(apiUrl).Result;

            // Parse result into Currency collection
            var result = JToken.Parse(response)["data"]["rates"].Value<JObject>();

            foreach (var prop in result.Properties())
            {
                var currency = new Currency()
                {
                    Id = prop.Name,
                    Price = GetPriceFromExchangeRate(decimal.Parse(prop.Value.ToString()))
                };

                currencies.Add(currency);
            }

            return currencies;
        }

        /// <summary>
        /// Calculates currency price based on exchange rate.
        /// </summary>
        public decimal GetPriceFromExchangeRate(decimal rate)
        {
            var price = 1 / rate;
            return price;
        }
    }
}