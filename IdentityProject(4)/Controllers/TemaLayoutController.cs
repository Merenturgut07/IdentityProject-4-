using Microsoft.AspNetCore.Mvc;

namespace IdentityProject_4_.Controllers
{
    public class TemaLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
