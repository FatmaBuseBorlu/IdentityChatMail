using IdentityChatMail.Context;
using IdentityChatMail.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IdentityChatMail.Controllers
{
    public class MessageController : Controller
    {
        private readonly MailContext _context;
        private readonly UserManager<AppUser> _userManager;
        public MessageController(MailContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Profile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v1 = values.Name + " " + values.Surname;
            ViewBag.v2 = values.Email;
            return View();
        }
        public async Task<IActionResult> Inbox(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var messageList = _context.Messages.Where(x => x.ReceiverEmail == values.Email && x.IsTrash == false).ToList();
            if (!string.IsNullOrEmpty(p))
            {
                messageList = messageList.Where(y => y.Subject.Contains(p) || y.MessageDetail.Contains(p)).ToList();
            }
            return View(messageList);
        }

        public async Task<IActionResult> Sendbox(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string email = values.Email;
            var sendMessageList = _context.Messages.Where(x => x.SenderEmail == email && x.IsTrash == false).ToList();

            if (!string.IsNullOrEmpty(p))
            {
                sendMessageList = sendMessageList.Where(y => y.Subject.Contains(p) || y.MessageDetail.Contains(p)).ToList();
            }

            return View(sendMessageList);
        }
        public async Task<IActionResult> Trash()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string email = values.Email;
            var trashList = _context.Messages.Where(x => (x.ReceiverEmail == email || x.SenderEmail == email) && x.IsTrash == true).ToList();

            return View(trashList);
        }
        public IActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(Message message)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string x = values.Email;

            message.SenderEmail = x;
            message.SendDate = DateTime.Now;
            message.IsRead = false;
            message.IsTrash = false;
            _context.Messages.Add(message);
            _context.SaveChanges();
            TempData["Durum"] = "ok";
            return RedirectToAction("Sendbox");
 
        }
        public IActionResult MessageDetail(int id)
        {
            var value = _context.Messages.Find(id);
            return View(value);
        }
     public IActionResult DeleteMessage(int id)
        {
            var message = _context.Messages.Find(id);
            if (message != null)
            {
                message.IsTrash = true; 
                _context.SaveChanges();
            }
            return RedirectToAction("Inbox");
        }
        public async Task<IActionResult> Important(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string email = values.Email;
            var list = _context.Messages
                .Where(x => (x.ReceiverEmail == email || x.SenderEmail == email) && x.IsTrash == false && x.IsImportant == true)
                .ToList();

            if (!string.IsNullOrEmpty(p))
            {
                list = list.Where(y => y.Subject.Contains(p) || y.MessageDetail.Contains(p)).ToList();
            }
            return View(list);
        }
        public IActionResult MakeImportant(int id)
        {
            var message = _context.Messages.Find(id);
            if (message != null)
            {
                message.IsImportant = !message.IsImportant;
                _context.SaveChanges();
            }
            return Ok(); 
        }
    }
}