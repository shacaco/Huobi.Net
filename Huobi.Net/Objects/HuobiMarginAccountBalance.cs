using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Huobi.Net.Objects
{
    public class HuobiMarginAccountBalance
    {
        /// <summary>
        /// Account Id
        /// </summary>
        public long Id { get; set; } 

        /// <summary>
        /// Account type
        /// </summary>
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// account state: working, fl-sys, fl-end, fl-negative
        /// </summary>
        public string State { get; set; } = string.Empty;

        /// <summary>
        /// Risk rate
        /// </summary>
        [JsonProperty("risk-rate")]
        public decimal RiskRate { get; set; }

        /// <summary>
        /// total account balance
        /// </summary>
        [JsonProperty("acct-balance-sum")]
        public decimal TotalAccountBalance { get; set; }

        /// <summary>
        /// total account debt
        /// </summary>
        [JsonProperty("debt-balance-sum")]
        public decimal TotalAccountDebt { get; set; }

        /// <summary>
        /// Balance items
        /// </summary>
        public IEnumerable<HuobiBalance> List = Array.Empty<HuobiBalance>();
    }
}
