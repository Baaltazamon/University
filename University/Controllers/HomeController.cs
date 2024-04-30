using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Data.Dto;
using University.Models;
using University.Service.IdentityService;
using University.Service.UniService;
using System.Security.Principal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;

namespace University.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUniService _service;
        private readonly IIdentityService _identity;

        public HomeController(ILogger<HomeController> logger, IUniService service, IIdentityService identity)
        {
            _logger = logger;
            _service = service;
            _identity = identity;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var qwe = HttpContext.User;
            await _identity.CreateStartUsers();
            var model = await _service.GetIndexModel();
            return View(model);
        }

        public IActionResult Menu()
        {
            return View();
        }
        
        [AllowAnonymous]
        public async Task<IActionResult> UniSearch(EduOrgFilter Filters)
        {
			
			var model = await _service.GetUniversity(Filters);
            return View(model);
        }

        [AllowAnonymous]
        public IActionResult About()
        {
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Programs(int? id)
        {
            var model = await _service.GetProgramModel(id);
            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> UniSingle(int id)
        {
	        var model = await _service.GetSingleUniversity(id);
	        if (model.Organization is null)
	        {
				TempData["ErrorMessage"] = "Учебное заведение не существует!";
				TempData["Page"] = "Index";
				TempData["Controller"] = "Home";
				return RedirectToAction("Error404");
			}
	        return View(model);
        }

        [AllowAnonymous]
        public IActionResult Error404(string message)
        {
	        ViewData["ErrorMessage"] = TempData["ErrorMessage"] as string;
	        ViewData["Page"] = TempData["Page"] as string;
	        ViewData["Controller"] = TempData["Controller"] as string;
			return View(message);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}