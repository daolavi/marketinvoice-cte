using Newtonsoft.Json;

namespace MarketInvoice.CTE.Models.Response
{
    public class LoanSummary
    {
        [JsonProperty("weeklyRepayment")]
        public decimal WeeklyRepayment { get; set; }

        [JsonProperty("totalRepaid")]
        public decimal TotalRepaid { get; set; }

        [JsonProperty("totalInterest")]
        public decimal TotalInterest { get; set; }
    }
}
