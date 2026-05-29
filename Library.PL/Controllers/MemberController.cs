using Microsoft.AspNetCore.Mvc;

namespace Library.PL.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
