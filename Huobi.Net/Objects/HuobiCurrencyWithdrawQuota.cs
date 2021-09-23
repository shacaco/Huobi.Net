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
		public string Chain { get; set; }
		/// <summary>
		/// The max number of crypto asset to withdraw per request
		/// </summary>
		public decimal MaxWithdrawAmt { get; set; }
		/// <summary>
		/// The number of crypto asset transfered in its minimum unit
		/// </summary>
		public decimal remainWithdrawQuotaPerDay { get; set; }
		/// <summary>
		/// The number of crypto asset transfered in its minimum unit
		/// </summary>
		public decimal withdrawQuotaPerYear { get; set; }
		/// <summary>
		/// The number of crypto asset transfered in its minimum unit
		/// </summary>
		public decimal remainWithdrawQuotaPerYear { get; set; }
		/// <summary>
		/// The number of crypto asset transfered in its minimum unit
		/// </summary>
		public decimal withdrawQuotaTotal { get; set; }
		/// <summary>
		/// The number of crypto asset transfered in its minimum unit
		/// </summary>
		public decimal remainWithdrawQuotaTotal { get; set; }
	}
}
