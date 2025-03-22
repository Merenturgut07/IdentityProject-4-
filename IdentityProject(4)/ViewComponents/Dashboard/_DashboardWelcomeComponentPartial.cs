using Identity.EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProject_4_.ViewComponents.Dashboard
{
    public class _DashboardWelcomeComponentPartial:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _DashboardWelcomeComponentPartial(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v1=values.Name+" "+ values.Surname;
            return View(values);
        }
    }
}
