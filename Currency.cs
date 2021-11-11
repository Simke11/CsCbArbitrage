namespace CsCbArbitrage
{
    public class Currency
    {
        ///<summary>
        /// Currency identifier (e.g. BTC, ETH).
        ///</summary>
        public string Id { get; set; }

        ///<summary>
        /// Currency price in AUD.
        ///</summary>
        public decimal Price { get; set; }
    }
}