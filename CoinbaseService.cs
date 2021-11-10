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
        public List<string> GetCoins()
        {
            throw new NotImplementedException();
        }
    }
}