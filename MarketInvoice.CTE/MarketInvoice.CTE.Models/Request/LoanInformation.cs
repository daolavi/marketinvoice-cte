using Newtonsoft.Json;

namespace MarketInvoice.CTE.Models.Request
{
    public class LoanInformation
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("apr")]
        public double APR { get; set; }
    }
}
