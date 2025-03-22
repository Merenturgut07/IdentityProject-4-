using Microsoft.AspNetCore.Mvc;

namespace IdentityProject_4_.ViewComponents.Dashboard
{
    public class _DashboardFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
