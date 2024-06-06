using Data.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using University.Models;
using University.Service.IdentityService;

namespace University.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IIdentityService _userManager;
        public UserController(IIdentityService userManager)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager)); ;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.GetAllUsers();
            return View(users);
        }

        [Authorize(Roles = "Администратор")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Администратор")]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var result = await _userManager.CreateUser(model);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "User");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(model);
        }

        [Authorize(Roles = "Администратор")]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.GetUserById(id);
            if (user is not null) return View(user);
            TempData["ErrorMessage"] = "Пользователь не существует!";
            TempData["Page"] = "Index";
            TempData["Controller"] = "User";
            return RedirectToAction("Error404", "Home");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Администратор")]
        public async Task<IActionResult> Edit(EditUserViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            var user = await _userManager.GetUserById(model.Id);
            if (user == null)
            {
                TempData["ErrorMessage"] = "Пользователь не существует!";
                TempData["Page"] = "Index";
                TempData["Controller"] = "User";
                return RedirectToAction("Error404", "Home");
            }

            var result = await _userManager.EditUser(model);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "User");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(model);
        }


        [Authorize(Roles = "Администратор")]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManager.GetUserById(id);
            if (user == null)
            {
                TempData["ErrorMessage"] = "Пользователь не существует!";
                TempData["Page"] = "Index";
                TempData["Controller"] = "User";
                return RedirectToAction("Error404", "Home");
            }
            var result = await _userManager.DeleteUser(id);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "User");
            }

            TempData["ErrorMessage"] = "Во время сохранения произошла ошибка!";
            return RedirectToAction("Error404", "Home");
        }
    }
}
