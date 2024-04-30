using Data.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using University.Service.UniService;

namespace University.Controllers
{
    [Authorize]
    public class SpecializationController : Controller
    {
        private readonly ILogger<SpecializationController> _logger;
        private readonly IUniService _service;

        public SpecializationController(ILogger<SpecializationController> logger, IUniService service)
        {
            _logger = logger;
            _service = service;
        }
        // GET: SpecializationController
        public async Task<ActionResult> Index()
        {
            var model = await _service.GetAllSpecialization();
            return View(model);
        }

        
        // GET: SpecializationController/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Specialization specialization)
        {
            if (ModelState.IsValid)
            {
                var id = await _service.AddSpecialization(specialization);
                if (id > 0)
                    return RedirectToAction("Index", "Specialization"); 
            }
            return View(specialization);
        }

        // GET: SpecializationController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var model = await _service.GetSingleSpecialization(id);
            if (model != null) return View(model);
            TempData["ErrorMessage"] = "Специальность не существует!";
            TempData["Page"] = "Index";
            TempData["Controller"] = "Specialization";
            return RedirectToAction("Error404", "Home");
        }

        // POST: SpecializationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Specialization specialization)
        {
            if (ModelState.IsValid)
            {
                var id = await _service.EditSpecialization(specialization);
                if (id)
                    return RedirectToAction("Index", "Specialization");
            }
            return View(specialization);
        }

        // GET: SpecializationController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var res = await _service.DeleteSpecialization(id);
            if (res)
                return RedirectToAction("Index", "Specialization");
            TempData["ErrorMessage"] = "Специальность не существует!";
            TempData["Page"] = "Index";
            TempData["Controller"] = "Specialization";
            return RedirectToAction("Error404", "Home");
        }

        
    }
}
