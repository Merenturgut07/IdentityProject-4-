using Microsoft.AspNetCore.Mvc;

namespace IdentityProject_4_.ViewComponents.Layout
{
    public class _LayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
