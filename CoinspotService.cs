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
        public List<string> GetCoins()
        {
            throw new NotImplementedException();
        }
    }
}