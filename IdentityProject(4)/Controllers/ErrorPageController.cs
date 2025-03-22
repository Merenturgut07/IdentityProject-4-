using Microsoft.AspNetCore.Mvc;

namespace IdentityProject_4_.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
