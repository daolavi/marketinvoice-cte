using MarketInvoice.CTE.Models.Request;
using MarketInvoice.CTE.Services.LoanService;
using Microsoft.AspNetCore.Mvc;

namespace MarketInvoice.CTE.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoanController
    {
        private readonly ILoanService _loanService;

        public LoanController(ILoanService loanService)
        {
            _loanService = loanService;
        }

        [HttpGet]
        [Route("loansummary")]
        public IActionResult LoanSummary([FromQuery] LoanInformation loanInformation)
        {
            var result = _loanService.GetLoanSummary(loanInformation);
            return new JsonResult(result);
        }

        [HttpGet]
        [Route("repaymentSchedule")]
        public IActionResult RepaymentSchedule([FromQuery] LoanInformation loanInformation)
        {
            var result = _loanService.GetRepaymentSchedule(loanInformation);
            return new JsonResult(result);
        }
    }
}
