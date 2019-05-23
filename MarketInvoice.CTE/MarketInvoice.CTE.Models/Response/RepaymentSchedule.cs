using System.Collections.Generic;
using Newtonsoft.Json;

namespace MarketInvoice.CTE.Models.Response
{
    public class RepaymentSchedule
    {
        [JsonProperty("installments")]
        public List<Installment> Installments { get; set; }
    }
}
