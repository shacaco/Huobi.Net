using System;
using System.Collections.Generic;


namespace Huobi.Net.Objects
{
    /// <summary>
    /// Withdraw Quota
    /// </summary>
    public class HuobiWithdrawQuota
	{
		/// <summary>
		/// The currency
		/// </summary>
        public string Currency { get; set; } = string.Empty;
        /// <summary>
        /// Chains
        /// </summary>
		public IEnumerable<HuobiCurrencyWithdrawQuota> Chains { get; set; } = Array.Empty<HuobiCurrencyWithdrawQuota>();
    }
}
