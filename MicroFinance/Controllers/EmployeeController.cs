using Microsoft.AspNetCore.Mvc;

namespace MicroFinance.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
