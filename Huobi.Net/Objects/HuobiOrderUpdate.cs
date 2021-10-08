﻿using System;
using CryptoExchange.Net.Attributes;
using CryptoExchange.Net.Converters;
using Huobi.Net.Converters;
using Newtonsoft.Json;

namespace Huobi.Net.Objects
{
    /// <summary>
    /// Order update
    /// </summary>
    public class HuobiOrderUpdate
    {
        /// <summary>
        /// The id of the order
        /// </summary>
        [JsonProperty("order-id")]
        public long Id { get; set; }

        /// <summary>
        /// The symbol of the order
        /// </summary>
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// The id of the account that placed the order
        /// </summary>
        [JsonProperty("account-id")]
        public long AccountId { get; set; }
        /// <summary>
        /// The amount of the order
        /// </summary>
        [JsonProperty("order-amount")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The price of the order
        /// </summary>
        [JsonProperty("order-price")]
        public decimal Price { get; set; }

        /// <summary>
        /// The time the order was created
        /// </summary>
        [JsonProperty("created-at"), JsonConverter(typeof(TimestampConverter))]
        public DateTime CreatedAt { get; set; }
        
        /// <summary>
        /// The type of the order
        /// </summary>
        [JsonProperty("order-type"), JsonConverter(typeof(OrderTypeConverter))]
        public HuobiOrderType Type { get; set; }


        /// <summary>
        /// The source of the order
        /// </summary>
        [JsonProperty("order-source"), JsonOptionalProperty]
        public string Source { get; set; } = string.Empty;

        /// <summary>
        /// The state of the order
        /// </summary>
        [JsonProperty("order-state"), JsonConverter(typeof(OrderStateConverter))]
        public HuobiOrderState State { get; set; }

        /// <summary>
        /// The role of the order
        /// </summary>
        [JsonProperty("role"), JsonConverter(typeof(OrderRoleConverter))]
        public HuobiOrderRole Role { get; set; }

        /// <summary>
        /// The amount of the order that is filled
        /// </summary>
        [JsonProperty("filled-amount"), JsonOptionalProperty]
        public decimal FilledQuantity { get; set; }

        /// <summary>
        /// Unfilled amount
        /// </summary>
        [JsonProperty("unfilled-amount"), JsonOptionalProperty]
        public decimal UnfilledQuantity { get; set; }
        /// <summary>
        /// Filled cash amount
        /// </summary>
        [JsonProperty("filled-cash-amount"), JsonOptionalProperty]
        public decimal FilledCashQuantity { get; set; }

        /// <summary>
        /// The amount of fees paid for the filled amount
        /// </summary>
        [JsonProperty("filled-fees"), JsonOptionalProperty]
        public decimal FilledFees { get; set; }
    }
}
