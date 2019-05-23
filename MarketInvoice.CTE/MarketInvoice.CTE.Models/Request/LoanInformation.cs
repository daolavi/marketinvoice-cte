using MarketInvoice.CTE.Constants;
using Newtonsoft.Json;

namespace MarketInvoice.CTE.Models.Request
{
    public class LoanInformation
    {
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("apr")]
        public decimal APR { get; set; }

        [JsonProperty("numberOfPayments")]
        public int NumberOfPayments { get; set; } = PaymentConstants.WEEKLY;
    }
}
