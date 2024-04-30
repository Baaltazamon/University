using Data.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using University.Models;
using University.Service.UniService;

namespace University.Controllers
{
    [Authorize]
    public class UniversityController : Controller
    {

        private readonly ILogger<UniversityController> _logger;
        private readonly IUniService _service;

        public UniversityController(ILogger<UniversityController> logger, IUniService service)
        {
            _logger = logger;
            _service = service;
        }
        // GET: UniversityController
        public async Task<ActionResult> Index()
        {
            var res = await _service.GetAllEducationalOrganization();
            return View(res);
        }

        
        // GET: UniversityController/Create
        public async Task<ActionResult> Create()
        {
            var viewModel = new UniversityViewModel
            {
                Cities = await _service.GetCity(),
                TypeEducationalOrganizations = await _service.GetTypes(),
                Organization = new EducationalOrganization()
            };
            return View(viewModel);
        }

        // POST: UniversityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(UniversityViewModel model)
        {
            if (ModelState.IsValid)
            {
                var id = await _service.AddEducationalOrganization(model.Organization, model.Image);
                if (id > 0)
                    return RedirectToAction("Index", "University");
            }

            var viewModel = new UniversityViewModel
            {
                Cities = await _service.GetCity(),
                TypeEducationalOrganizations = await _service.GetTypes(),
                Organization = model.Organization
            };
            return View(viewModel);
        }

        // GET: UniversityController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var model = await _service.GetSingleEducationalOrganization(id);
            if (model != null)
            {
                var viewModel = new UniversityEditViewModel
                {
                    Cities = await _service.GetCity(),
                    TypeEducationalOrganizations = await _service.GetTypes(),
                    Organization = model
                };
                return View(viewModel);
            }
            TempData["ErrorMessage"] = "Учебное заведение не существует!";
            TempData["Page"] = "Index";
            TempData["Controller"] = "University";
            return RedirectToAction("Error404", "Home");
        }

        // POST: UniversityController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(UniversityEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var id = await _service.EditEducationalOrganization(model.Organization, model.Image);
                if (id)
                    return RedirectToAction("Index", "University");
            }
            var viewModel = new UniversityEditViewModel
            {
                Cities = await _service.GetCity(),
                TypeEducationalOrganizations = await _service.GetTypes(),
                Organization = model.Organization
            };
            return View(viewModel);
        }

        // GET: UniversityController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var org = await _service.GetSingleEducationalOrganization(id);
            if (org == null)
            {
                TempData["ErrorMessage"] = "Учебное заведение не существует!";
                TempData["Page"] = "Index";
                TempData["Controller"] = "University";
                return RedirectToAction("Error404", "Home");
            }
            var result = await _service.DeleteEducationalOrganization(id);
            if (result)
                return RedirectToAction("Index", "University");
            TempData["ErrorMessage"] = "Удаление не произошло, база недоступна!";
            TempData["Page"] = "Index";
            TempData["Controller"] = "University";
            return RedirectToAction("Error404", "Home");
        }

        
    }
}
