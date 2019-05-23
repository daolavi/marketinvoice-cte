using MarketInvoice.CTE.Models.Request;
using MarketInvoice.CTE.Services.LoanService;
using Xunit;

namespace MarketInvoice.CTE.Tests
{
    public class LoanServiceTest
    {
        [Fact]
        public void LoanSummaryTest()
        {
            var loanInformation = new LoanInformation()
            {
                Amount = 50000,
                APR = 19,
                NumberOfPayments = 52,
            };
            var loanService = new LoanService();
            var loanSummary = loanService.GetLoanSummary(loanInformation);

            Assert.Equal(1057.53m, loanSummary.WeeklyRepayment);
            Assert.Equal(54991.56m, loanSummary.TotalRepaid);
            Assert.Equal(4991.56m, loanSummary.TotalInterest);
        }

        [Fact]
        public void LoanSummaryTest_With_Default_NumberOfPayments()
        {
            var loanInformation = new LoanInformation()
            {
                Amount = 40000,
                APR = 10,
            };
            var loanService = new LoanService();
            var loanSummary = loanService.GetLoanSummary(loanInformation);

            Assert.Equal(809.07m, loanSummary.WeeklyRepayment);
            Assert.Equal(42071.64m, loanSummary.TotalRepaid);
            Assert.Equal(2071.64m, loanSummary.TotalInterest);
        }

        [Fact]
        public void RepaymentScheduleTest()
        {
            var loanInformation = new LoanInformation()
            {
                Amount = 50000,
                APR = 19,
                NumberOfPayments = 52,
            };
            var loanService = new LoanService();
            var repaymentSchedule = loanService.GetRepaymentSchedule(loanInformation);

            Assert.Equal(loanInformation.NumberOfPayments, repaymentSchedule.Installments.Count);
            Assert.Equal(50000m, repaymentSchedule.Installments[0].AmountDue);
            Assert.Equal(874.84m, repaymentSchedule.Installments[0].Principal);
            Assert.Equal(182.69m, repaymentSchedule.Installments[0].Interest);

            Assert.Equal(27142.67m, repaymentSchedule.Installments[25].AmountDue);
            Assert.Equal(958.35m, repaymentSchedule.Installments[25].Principal);
            Assert.Equal(99.18m, repaymentSchedule.Installments[25  ].Interest);

            Assert.Equal(1053.45m, repaymentSchedule.Installments[51].AmountDue);
            Assert.Equal(1053.68m, repaymentSchedule.Installments[51].Principal);
            Assert.Equal(3.85m, repaymentSchedule.Installments[51].Interest);
        }

        [Fact]
        public void RepaymentScheduleTest_With_Default_NumberOfPayments()
        {
            var loanInformation = new LoanInformation()
            {
                Amount = 30000,
                APR = 10,
            };
            var loanService = new LoanService();
            var repaymentSchedule = loanService.GetRepaymentSchedule(loanInformation);

            Assert.Equal(loanInformation.NumberOfPayments, repaymentSchedule.Installments.Count);
            Assert.Equal(30000m, repaymentSchedule.Installments[0].AmountDue);
            Assert.Equal(549.11m, repaymentSchedule.Installments[0].Principal);
            Assert.Equal(57.69m, repaymentSchedule.Installments[0].Interest);

            Assert.Equal(15950.82m, repaymentSchedule.Installments[25].AmountDue);
            Assert.Equal(576.13m, repaymentSchedule.Installments[25].Principal);
            Assert.Equal(30.67m, repaymentSchedule.Installments[25].Interest);

            Assert.Equal(605.89m, repaymentSchedule.Installments[51].AmountDue);
            Assert.Equal(605.63m, repaymentSchedule.Installments[51].Principal);
            Assert.Equal(1.17m, repaymentSchedule.Installments[51].Interest);
        }

        [Fact]
        public void RepaymentScheduleTest_With_MonthlyPaymen()
        {
            var loanInformation = new LoanInformation()
            {
                Amount = 20000,
                APR = 10,
                NumberOfPayments = 12,
            };
            var loanService = new LoanService();
            var repaymentSchedule = loanService.GetRepaymentSchedule(loanInformation);

            Assert.Equal(loanInformation.NumberOfPayments, repaymentSchedule.Installments.Count);
            Assert.Equal(20000m, repaymentSchedule.Installments[0].AmountDue);
            Assert.Equal(1591.65m, repaymentSchedule.Installments[0].Principal);
            Assert.Equal(166.67m, repaymentSchedule.Installments[0].Interest);

            Assert.Equal(11907.98m, repaymentSchedule.Installments[5].AmountDue);
            Assert.Equal(1659.09m, repaymentSchedule.Installments[5].Principal);
            Assert.Equal(99.23m, repaymentSchedule.Installments[5].Interest);

            Assert.Equal(1743.76m, repaymentSchedule.Installments[11].AmountDue);
            Assert.Equal(1743.79m, repaymentSchedule.Installments[11].Principal);
            Assert.Equal(14.53m, repaymentSchedule.Installments[11].Interest);
        }
    }
}
