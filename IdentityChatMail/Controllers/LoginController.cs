using IdentityChatMail.Entities;
using IdentityChatMail.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityChatMail.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> UserLogin(LoginViewModel model)
        {
            var result= await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, true);
            if (result.Succeeded)
            {
                return RedirectToAction("Inbox", "Message");
            }
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("UserLogin", "Login");
        }

    }
}
