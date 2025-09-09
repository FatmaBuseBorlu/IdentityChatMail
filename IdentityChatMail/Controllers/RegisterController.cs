using IdentityChatMail.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityChatMail.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _username;

        public RegisterController(UserManager<AppUser> username)
        {
            _username = username;
        }
        [HttpGet]

        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
       public async Task<IActionResult> CreateUser()
        {
            
        }
    }
}
