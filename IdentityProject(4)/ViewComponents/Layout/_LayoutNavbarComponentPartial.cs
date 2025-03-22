using Identity.BussinessLayer.Abstract;
using Identity.EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProject_4_.ViewComponents.Layout
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        private readonly INotificationService _notificationService;

        private readonly UserManager<AppUser> _userManager;

        public _LayoutNavbarComponentPartial(INotificationService notificationService, UserManager<AppUser> userManager)
        {
            _notificationService = notificationService;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values1 = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.w1 = values1.ImageUrl;

            var values = _notificationService.TGetListAll();
            return View(values);
        }
    }
}
