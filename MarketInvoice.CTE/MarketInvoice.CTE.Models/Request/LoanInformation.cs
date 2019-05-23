using MarketInvoice.CTE.Constants;
using MarketInvoice.CTE.Validations;
using Newtonsoft.Json;


namespace MarketInvoice.CTE.Models.Request
{
    public class LoanInformation
    {
        [JsonProperty("amount")]
        [RequiredGreaterThanZero]
        public decimal Amount { get; set; }
        
        [JsonProperty("apr")]
        [RequiredGreaterThanZero]
        public decimal APR { get; set; }

        [JsonProperty("numberOfPayments")]
        [RequiredGreaterThanZero]
        public int NumberOfPayments { get; set; } = PaymentConstants.WEEKLY;
    }
}
