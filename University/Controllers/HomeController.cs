using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Data.Dto;
using University.Models;
using University.Service.UniService;

namespace University.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUniService _service;

        public HomeController(ILogger<HomeController> logger, IUniService service)
        {
            _logger = logger;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _service.GetIndexModel();
            return View(model);
        }

        public async Task<IActionResult> UniSearch(EduOrgFilter Filters)
        {
			
			var model = await _service.GetUniversity(Filters);
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }

        public async Task<IActionResult> Programs(int? id)
        {
            var model = await _service.GetProgramModel(id);
            return View(model);
        }

        public async Task<IActionResult> UniSingle(int id)
        {
	        var model = await _service.GetSingleUniversity(id);
	        if (model.Organization is null)
	        {
				TempData["ErrorMessage"] = "Учебное заведение не существует!";
				return RedirectToAction("Error404");
			}
	        return View(model);
        }

        public IActionResult Error404(string message)
        {
	        ViewData["ErrorMessage"] = TempData["ErrorMessage"] as string;
			return View(message);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}