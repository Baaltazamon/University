using System.Security.Claims;
using Data.Context;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using University.Models;
using University.Service.IdentityService;

namespace University.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly IIdentityService _identity;
        private readonly ILogger<AccountController> _logger;
        private readonly SignInManager<User> _signInManager;

        public AccountController(ILogger<AccountController> logger, IIdentityService identity, SignInManager<User> signInManager)
        {
            _logger = logger;
            _identity = identity;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        public async Task<ActionResult> Login(string returnUrl)
        {
            return View(new InputModel());
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(InputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
            
            if (result.Succeeded)
            {
                var user = await _identity.GetUserByName(model.UserName);
                var role = await _identity.GetUserRole(user);
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.GivenName, user.UserName),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.MobilePhone, user.PhoneNumber),
                    new Claim(ClaimTypes.Role, role),
                    new Claim(ClaimTypes.Name, $"{user.LastName} {user.FirstName} {user.MiddleName}")
                };
                await _signInManager.SignInWithClaimsAsync(user, isPersistent: false, claims);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError(string.Empty, "Неверная попытка входа в систему.");
            return View(model);
        }
        
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            // Перенаправление на главную страницу или другую страницу после выхода
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
