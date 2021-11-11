using System;

namespace CsCbArbitrage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting coins from Coinbase...");

            var coinbaseService = new CoinbaseService();
            var coinbaseCoins = coinbaseService.GetCurrencies();

            Console.WriteLine("Done.");

            Console.WriteLine("Getting coins from CoinSpot...");

            Console.WriteLine("Done.");

            Console.WriteLine("Finding arbitrage opportunities...");
        }
    }
}
