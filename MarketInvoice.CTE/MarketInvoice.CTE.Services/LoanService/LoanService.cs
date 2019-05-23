using MarketInvoice.CTE.Helpers;
using MarketInvoice.CTE.Models.Request;
using MarketInvoice.CTE.Models.Response;
using System.Collections.Generic;

namespace MarketInvoice.CTE.Services.LoanService
{
    public class LoanService : ILoanService
    {
        public LoanSummary GetLoanSummary(LoanInformation loanInformation)
        {
            var loanSummary = new LoanSummary
            {
                WeeklyRepayment = PaymentHelpers.GetPayment(loanInformation.Amount, loanInformation.NumberOfPayments, loanInformation.APR)
            };
            loanSummary.TotalRepaid = loanSummary.WeeklyRepayment * loanInformation.NumberOfPayments;
            loanSummary.TotalInterest = loanSummary.TotalRepaid - loanInformation.Amount;
            return loanSummary;
        }

        public RepaymentSchedule GetRepaymentSchedule(LoanInformation loanInformation)
        {
            var repaymentSchedule = new RepaymentSchedule()
            {
                Installments = new List<Installment>()
            };

            var payment = PaymentHelpers.GetPayment(loanInformation.Amount, loanInformation.NumberOfPayments, loanInformation.APR);

            var amountDue = loanInformation.Amount;
            for (var i = 0; i < loanInformation.NumberOfPayments; i++)
            {
                var installment = new Installment
                {
                    InstallmentNumber = i + 1
                };
                installment.AmountDue = amountDue;
                installment.Interest = PaymentHelpers.GetInterest(amountDue, loanInformation.NumberOfPayments, loanInformation.APR);
                installment.Principal = payment - installment.Interest;

                amountDue -= installment.Principal;

                repaymentSchedule.Installments.Add(installment);
            }

            return repaymentSchedule;
        }
    }
}
