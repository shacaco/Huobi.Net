namespace Huobi.Net.Objects
{
    /// <summary>
    /// Withdraw address info
    /// </summary>
    public class HuobiWithdrawAddress 
    {
        /// <summary>
        /// Crypto currency
        /// </summary>
        public string Currency { get; set; } = string.Empty;
        /// <summary>
        /// Withdraw address
        /// </summary>
        public string Address { get; set; } = string.Empty;
        /// <summary>
        /// Withdraw address tag
        /// </summary>
        public string AddressTag { get; set; } = string.Empty;
        /// <summary>
        /// Block chain name
        /// </summary>
        public string Chain { get; set; } = string.Empty;
        /// <summary>
        /// Withdraw address note
        /// </summary>
        public string Note { get; set; } = string.Empty;
    }
}
