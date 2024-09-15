using Microsoft.AspNetCore.Mvc;

namespace MicroFinance.Controllers
{
    public class LoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MemberLoanForm()
        {
            return View();
        }
        public IActionResult MemberLoanViewDetails()
        {
            return View();
        }
    }
}
