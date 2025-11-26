using IdentityChatMail.Context;
using IdentityChatMail.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
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
            ViewBag.SearchTerm = p;
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var messageList = _context.Messages
                .Where(x => x.ReceiverEmail == values.Email && x.IsTrash == false)
                .OrderByDescending(x => x.MessageId) 
                .ToList();
            if (!string.IsNullOrEmpty(p))
            {
                p = p.ToLower();
                messageList = messageList.Where(x => x.Subject != null && x.Subject.ToLower().Contains(p)).ToList();
            }
            return View(messageList);
        }
        public async Task<IActionResult> Sendbox(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string email = values.Email;

            var sendMessageList = _context.Messages
                .Where(x => x.SenderEmail == values.Email && x.IsTrash == false)
                .OrderByDescending(x => x.MessageId)
                .ToList();

            if (!string.IsNullOrEmpty(p))
            {
                p = p.ToLower();
                sendMessageList = sendMessageList.Where(x => x.Subject != null && x.Subject.ToLower().Contains(p)).ToList();
            }
            return View(sendMessageList);
        }
        public async Task<IActionResult> Trash(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var trashList = _context.Messages
                    .Where(x => (x.ReceiverEmail == values.Email || x.SenderEmail == values.Email) && x.IsTrash == true)
                    .OrderByDescending(x => x.MessageId)
                    .ToList();
            if (!string.IsNullOrEmpty(p))
            {
                p = p.ToLower();
                trashList = trashList.Where(x => x.Subject != null && x.Subject.ToLower().Contains(p)).ToList();
            }

            return View(trashList);
        }
        public IActionResult CreateMessage(string? alici, string? konu)
        {
            Message model = new Message();

            if (!string.IsNullOrEmpty(alici))
            {
                model.ReceiverEmail = alici; 
            }

            if (!string.IsNullOrEmpty(konu))
            {
                model.Subject = "Re: " + konu; 
            }

            return View(model); 
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
            if (value == null) return RedirectToAction("Inbox");
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
            var importantList = _context.Messages
          .Where(x => (x.ReceiverEmail == values.Email || x.SenderEmail == values.Email) && x.IsTrash == false && x.IsImportant == true)
          .OrderByDescending(x => x.MessageId)
          .ToList();
            if (!string.IsNullOrEmpty(p))
            {
                p = p.ToLower();
                importantList = importantList.Where(x => x.Subject != null && x.Subject.ToLower().Contains(p)).ToList();
            }
            return View(importantList);
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