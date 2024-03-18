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

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> UniSearch(EduOrgFilter Filters)
        {
            var model = await _service.GetUniversity(Filters);
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}