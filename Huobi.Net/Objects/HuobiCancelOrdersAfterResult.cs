using CryptoExchange.Net.Converters;
using Newtonsoft.Json;
using System;

namespace Huobi.Net.Objects
{
    /// <summary>
    /// Cancel after result
    /// </summary>
    public class HuobiCancelOrdersAfterResult
    {
        /// <summary>
        /// Current time
        /// </summary>
        [JsonProperty("currentTime"), JsonConverter(typeof(TimestampConverter))]
        public DateTime CurrentTime { get; set; }
        /// <summary>
        /// Trigger time
        /// </summary>
        [JsonProperty("triggerTime"), JsonConverter(typeof(TimestampConverter))]
        public DateTime TriggerTime { get; set; }
    }
}
