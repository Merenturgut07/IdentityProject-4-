using Identity.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProject_4_.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AllMessageController : Controller
    {
        private readonly IMessageService _messageService;

        public AllMessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            var values = _messageService.TGetListAll();
            return View(values);
        }

        public IActionResult DeleteMessage(int id)
        {
            _messageService.TDelete(id);
            return RedirectToAction("Index");
        }

    }
}
