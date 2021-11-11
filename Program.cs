using System;

namespace CsCbArbitrage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting coins from Coinbase...");

            var coinbaseService = new CoinbaseService();
            var coinbaseCurrencies = coinbaseService.GetCurrencies();

            Console.WriteLine($"Done. Found {coinbaseCurrencies.Count} currencies.");

            Console.WriteLine("Getting coins from CoinSpot...");

            Console.WriteLine("Done.");

            Console.WriteLine("Finding arbitrage opportunities...");
        }
    }
}
