using Microsoft.AspNetCore.Mvc;

namespace MarketInvoice.CTE.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoanController
    {
        public LoanController()
        {
        }

        [HttpGet]
        [Route("loansummary")]
        public IActionResult LoanSummary()
        {
            return new JsonResult("Ok");
        }

        [HttpGet]
        [Route("repaymentSchedule")]
        public IActionResult RepaymentSchedule()
        {
            return new JsonResult("Ok");
        }
    }
}
