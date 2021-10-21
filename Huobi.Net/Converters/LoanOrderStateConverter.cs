using CryptoExchange.Net.Converters;
using Huobi.Net.Objects;
using System.Collections.Generic;

namespace Huobi.Net.Converters
{
    internal class LoanOrderStateConverter : BaseConverter<HuobiLoanState>
    {
        public LoanOrderStateConverter() : this(true) { }
        public LoanOrderStateConverter(bool quotes) : base(quotes) { }

        protected override List<KeyValuePair<HuobiLoanState, string>> Mapping => new List<KeyValuePair<HuobiLoanState, string>>
        {
            new KeyValuePair<HuobiLoanState, string>(HuobiLoanState.Created, "created"),
            new KeyValuePair<HuobiLoanState, string>(HuobiLoanState.Accrual, "accrual"),
            new KeyValuePair<HuobiLoanState, string>(HuobiLoanState.Cleared, "cleared"),
            new KeyValuePair<HuobiLoanState, string>(HuobiLoanState.Invalid, "invalid")
        };
    }
}
