using System;
using System.Collections.Generic;
using System.Text;

namespace Huobi.Net.Objects
{
    /// <summary>
    /// Info on a user fees
    /// </summary>
    public class HuobiSymbolFees
    {
        /// <summary>
        /// Trading symbol
        /// </summary>
        public string Symbol { get; set; } = string.Empty;
        /// <summary>
        /// Basic fee rate – passive side (positive value);If maker rebate applicable, revert maker rebate rate (negative value).
        /// </summary>
        public decimal MakerFeeRate { get; set; }
        /// <summary>
        /// Basic fee rate – aggressive side
        /// </summary>
        public decimal TakerFeeRate { get; set; }
        /// <summary>
        /// Deducted fee rate – passive side (positive value). If deduction is inapplicable or disabled, return basic fee rate.If maker rebate applicable, revert maker rebate rate (negative value).
        /// </summary>
        public decimal ActualMakerRate { get; set; }
        /// <summary>
        /// Deducted fee rate – aggressive side. If deduction is inapplicable or disabled, return basic fee rate.
        /// </summary>
        public decimal ActualTakerRate { get; set; }
    }
}
