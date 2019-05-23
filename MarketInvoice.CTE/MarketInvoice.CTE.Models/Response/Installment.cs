using Newtonsoft.Json;

namespace MarketInvoice.CTE.Models.Response
{
    public class Installment
    {
        [JsonProperty("installmentNumber")]
        public int InstallmentNumber { get; set; }

        [JsonProperty("amountDue")]
        public decimal AmountDue { get; set; }

        [JsonProperty("principal")]
        public decimal Principal { get; set; }

        [JsonProperty("interest")]
        public decimal Interest { get; set; }
    }
}
