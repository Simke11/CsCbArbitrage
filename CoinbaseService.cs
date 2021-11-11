using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using Newtonsoft.Json;

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

            var currencies = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(result);

            //foreach (var c in currencies.data.rates)
            //{
            //    object o = c;
              //  string[] propertyNames = o.GetType().GetProperties().Select(p => p.Name).ToArray();
                //foreach (var prop in propertyNames)
                //{
                 //   object propValue = o.GetType().GetProperty(prop).GetValue(o, null);
                //}
            //}

            Console.WriteLine(result);

            return new List<Currency>();
        }
    }
}