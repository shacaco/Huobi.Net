using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Huobi.Net.Objects
{
    public class HuobiMarginLoanRepay
    {
        /// <summary>
        /// RepayId
        /// </summary>
        public string RepayId { get; set; } = string.Empty;
        /// <summary>
        /// RepayTime
        /// </summary>
        [JsonConverter(typeof(TimestampConverter))]
        public DateTime RepayTime { get; set; } 
    }
}
