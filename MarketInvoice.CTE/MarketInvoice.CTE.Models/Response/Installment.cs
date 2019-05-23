using Newtonsoft.Json;

namespace MarketInvoice.CTE.Models.Response
{
    public class Installment
    {
        [JsonProperty("installmentNumber")]
        public int InstallmentNumber { get; set; }

        [JsonProperty("amountDue")]
        public double AmountDue { get; set; }

        [JsonProperty("principal")]
        public double Principal { get; set; }

        [JsonProperty("interest")]
        public double Interest { get; set; }
    }
}
