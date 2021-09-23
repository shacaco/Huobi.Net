using System;

namespace Huobi.Net.Objects
{
    /// <summary>
    /// Single Currency Withdraw Quote
    /// </summary>
    public class HuobiCurrencyWithdrawQuota
	{
		/// <summary>
		/// Block chain name
		/// </summary>
		public string Chain { get; set; } = String.Empty;
        /// <summary>
        /// Maximum withdraw amount in each request
        /// </summary>
        public decimal MaxWithdrawAmt { get; set; }
        /// <summary>
        /// Maximum withdraw amount in a day
        /// </summary>
        public decimal WithdrawQuotaPerDay { get; set; }
        /// <summary>
        /// Remaining withdraw quota in the day
        /// </summary>
		public decimal RemainWithdrawQuotaPerDay { get; set; }
        /// <summary>
        /// Maximum withdraw amount in a year
        /// </summary>
		public decimal WithdrawQuotaPerYear { get; set; }
        /// <summary>
        /// Remaining withdraw quota in the year
        /// </summary>
		public decimal RemainWithdrawQuotaPerYear { get; set; }
        /// <summary>
        /// Maximum withdraw amount in total
        /// </summary>
        public decimal WithdrawQuotaTotal { get; set; }
        /// <summary>
        /// Remaining withdraw quota in total
        /// </summary>
        public decimal RemainWithdrawQuotaTotal { get; set; }
	}
}
