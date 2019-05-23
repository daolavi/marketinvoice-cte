using MarketInvoice.CTE.Models.Request;
using MarketInvoice.CTE.Models.Response;

namespace MarketInvoice.CTE.Services.LoanService
{
    public class LoanService : ILoanService
    {
        public LoanSummary GetLoanSummary(LoanInformation loanInformation)
        {
            return new LoanSummary();
        }

        public RepaymentSchedule GetRepaymentSchedule(LoanInformation loanInformation)
        {
            return new RepaymentSchedule();
        }
    }
}
