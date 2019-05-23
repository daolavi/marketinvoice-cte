using MarketInvoice.CTE.Models.Request;
using MarketInvoice.CTE.Models.Response;

namespace MarketInvoice.CTE.Services.LoanService
{
    public interface ILoanService
    {
        LoanSummary GetLoanSummary(LoanInformation loanInformation);

        RepaymentSchedule GetRepaymentSchedule(LoanInformation loanInformation);
    }
}
