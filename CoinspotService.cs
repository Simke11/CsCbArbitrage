using System;
using System.Collections.Generic;

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
            throw new NotImplementedException();
        }
    }
}