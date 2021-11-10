using System;
using System.Collections.Generic;

namespace CsCbArbitrage
{
    public interface ICoinbaseService
    {
        List<string> GetCoins();
    }

    public class CoinbaseService : ICoinbaseService
    {
        /// <summary>
        /// Gets list of coins available on Coinbase exchange, along with exchange rates against AUD.
        /// </summary>
        public List<string> GetCoins()
        {
            var apiUrl = "https://api.coinbase.com/v2/exchange-rates?currency=AUD";
            
            throw new NotImplementedException();
        }
    }
}