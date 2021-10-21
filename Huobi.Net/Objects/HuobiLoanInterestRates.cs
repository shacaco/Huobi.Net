using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Huobi.Net.Objects
{
    /// <summary>
    /// loan rates for the currency
    /// </summary>
    public class HuobiLoanInterestRates
    {
        /// <summary>
        /// Currency
        /// </summary>
        public string Currency { get; set; } = string.Empty;
       
        /// <summary>
        /// Basic daily interest rate
        /// </summary>
        [JsonProperty("interest-rate")]
        public decimal InterestRate { get; set; }

        /// <summary>
        /// Minimal loanable amount
        /// </summary>
        [JsonProperty("min-loan-amt")]
        public decimal MinLoanAmount { get; set; }

        /// <summary>
        /// Maximum loanable amount
        /// </summary>
        [JsonProperty("max-loan-amt")]
        public decimal MaxLoanAmount { get; set; }

        /// <summary>
        /// Remaining loanable amount
        /// </summary>
        [JsonProperty("loanable-amt")]
        public decimal LoanableAmount { get; set; }

        /// <summary>
        /// Actual interest rate post deduction (if deduction is inapplicable or disabled, return basic daily interest rate)
        /// </summary>
        [JsonProperty("actual-rate")]
        public decimal ActualRate { get; set; }
    }
}
