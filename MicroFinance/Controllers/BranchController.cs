using Microsoft.AspNetCore.Mvc;

namespace MicroFinance.Controllers
{
    public class BranchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateBranch()
        {
            return View();
        }
        public IActionResult BranchDetails()
        {
            return View();
        }
        public IActionResult CreateCenter()
        {
            return View();
        }
    }
}
