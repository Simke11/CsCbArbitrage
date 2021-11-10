using System;
using System.Collections.Generic;

namespace CsCbArbitrage
{
    public interface ICoinspotService
    {
        List<string> GetCoins();
    }

    public class CoinspotService : ICoinspotService
    {
        /// <summary>
        /// Gets list of coins available on CoinSpot exchange.
        /// </summary>
        public List<string> GetCoins()
        {
            throw new NotImplementedException();
        }
    }
}