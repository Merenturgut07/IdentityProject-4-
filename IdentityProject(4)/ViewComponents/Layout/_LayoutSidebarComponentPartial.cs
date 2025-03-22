using Microsoft.AspNetCore.Mvc;

namespace IdentityProject_4_.ViewComponents.Layout
{
    public class _LayoutSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
