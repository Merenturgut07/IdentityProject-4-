using Identity.DataAccessLayer.Context;
using Identity.EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProject_4_.ViewComponents.Dashboard
{
    public class _DashboardStatisticComponentPartial : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _DashboardStatisticComponentPartial(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            IdentityContext c = new IdentityContext();
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v1 = c.notifications.Count();
            ViewBag.v2 = c.Users.Count();
            ViewBag.v3 = c.messages.Where(x => x.Receiver == user.Email).Count();
            ViewBag.v4 = c.messages.Where(x => x.Sender == user.Email).Count();
            return View();
        }
    }
}
