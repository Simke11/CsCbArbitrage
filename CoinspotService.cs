using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace CsCbArbitrage
{
    public interface ICoinspotService
    {
        List<Currency> GetCurrencies();
    }

    public class CoinspotService : ICoinspotService
    {
        /// <summary>
        /// Gets list of currencies available on CoinSpot exchange.
        /// </summary>
        public List<Currency> GetCurrencies()
        {
            var currencies = new List<Currency>();

            // Call API
            var apiUrl = "https://www.coinspot.com.au/pubapi/v2/latest";
            var client = new HttpClient();
            var response = client.GetStringAsync(apiUrl).Result;

            // Parse result into Currency collection
            var result = JToken.Parse(response)["prices"].Value<JObject>();

            return currencies;
        }
    }
}