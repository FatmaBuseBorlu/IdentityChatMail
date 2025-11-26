using IdentityChatMail.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityChatMail.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> UserDetail()
        {
            var values=await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v1 = values.Name;
            ViewBag.v2 = values.Surname;
            ViewBag.v3 = values.Email;
            return View();
        }
    }
}
