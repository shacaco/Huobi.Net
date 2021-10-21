using CryptoExchange.Net.Converters;
using Huobi.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Huobi.Net.Objects
{
    public class HuobiLoanOrder
    {
        /// <summary>
        /// Order id
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Account id
        /// </summary>
        [JsonProperty("account-id")]
        public string AccountId { get; set; } = string.Empty;

        /// <summary>
        /// User id
        /// </summary>
        [JsonProperty("user-id")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// The currency in the loan
        /// </summary>
        public string Currency { get; set; } = string.Empty;

        /// <summary>
        /// Point deduction amount
        /// </summary>
        [JsonProperty("filled-points")]
        public decimal FilledPoints { get; set; }

        /// <summary>
        /// HT deduction amount
        /// </summary>
        [JsonProperty("filled-ht")]
        public decimal FilledHT { get; set; }

        /// <summary>
        /// The timestamp in milliseconds when the last accure happened
        /// </summary>
        [JsonProperty("accrued-at")]
        [JsonConverter(typeof(TimestampConverter))]
        public DateTime Accrued { get; set; }

        /// <summary>
        /// The timestamp when the order was created
        /// </summary>
        [JsonProperty("created-at")]
        [JsonConverter(typeof(TimestampConverter))]
        public DateTime Created { get; set; }

        /// <summary>
        /// The amount of the origin loan
        /// </summary>
        [JsonProperty("loan-amount")]
        public decimal LoanAmount { get; set; }

        /// <summary>
        /// The amount of the loan left
        /// </summary>
        [JsonProperty("loan-balance")]
        public decimal LoanBalance { get; set; }

        /// <summary>
        /// The accumulated loan interest
        /// </summary>
        [JsonProperty("interest-amount")]
        public decimal InterestAmount { get; set; }

        /// <summary>
        /// The amount of loan interest left
        /// </summary>
        [JsonProperty("interest-balance")]
        public decimal InterestBalance { get; set; }

        /// <summary>
        /// Actual interest rate post deduction (if deduction is inapplicable or disabled, return basic daily interest rate)
        /// </summary>
        [JsonProperty("state"), JsonConverter(typeof(LoanOrderStateConverter))]
        public HuobiLoanState State { get; set; }
    }
}
