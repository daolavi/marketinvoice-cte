using Newtonsoft.Json;

namespace MarketInvoice.CTE.Models.Response
{
    public class LoanSummary
    {
        [JsonProperty("weeklyRepayment")]
        public double WeeklyRepayment { get; set; }

        [JsonProperty("totalRepaid")]
        public double TotalRepaid { get; set; }

        [JsonProperty("totalInterest")]
        public double TotalInterest { get; set; }
    }
}
