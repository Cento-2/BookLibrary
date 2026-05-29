using Microsoft.AspNetCore.Mvc;

namespace Library.PL.Controllers
{
    public class LoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
