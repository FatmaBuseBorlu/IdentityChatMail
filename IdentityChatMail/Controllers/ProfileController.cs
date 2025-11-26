using IdentityChatMail.Entities;
using IdentityChatMail.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

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
            ViewBag.v4 = values.ProfileImageUrl ?? "/quixlab-master/images/user/1.png";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UserDetail(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Name = p.Name;
            user.Surname = p.Surname;
            if (p.Password != null)
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            }

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("UserDetail", "Profile");
            }

            return View();
        }
    }
}