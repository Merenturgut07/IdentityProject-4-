using Identity.BussinessLayer.Abstract;
using Identity.BussinessLayer.Concrate;
using Identity.DataAccessLayer.Context;
using Identity.DataAccessLayer.EntityFramework;
using Identity.EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProject_4_.Controllers
{
    public class MessageController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());

        private readonly UserManager<AppUser> _userManager;

        public MessageController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Receiver(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = messageManager.GetListReceiverMessage(p);
            return View(messageList);
        }

        public async Task<IActionResult> Sender(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = messageManager.GetListSenderMessage(p);
            return View(messageList);
        }

        public IActionResult MessageDetails(int id)
        {
            Message message = messageManager.TGetById(id);
            return View(message);
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(Message p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name=values.Name+" "+ values.Surname;
            p.MessageDate=Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = "true";
            p.Sender = mail;
            p.SenderName = name;

            IdentityContext c=new IdentityContext();

            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;

            messageManager.TInsert(p);
            return RedirectToAction("Sender", "Message");
        }

    }
}
