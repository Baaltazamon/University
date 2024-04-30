using Data.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.Models;
using University.Service.UniService;

namespace University.Controllers
{
    [Authorize]
    public class ProgramController : Controller
    {

        private readonly ILogger<ProgramController> _logger;
        private readonly IUniService _service;

        public ProgramController(ILogger<ProgramController> logger, IUniService service)
        {
            _logger = logger;
            _service = service;
        }
        // GET: ProgramController
        public async Task<ActionResult> Index()
        {
            var model = await _service.GetProgramListModel();
            return View(model);
        }
        

        // GET: ProgramController/Create
        public async Task<ActionResult> Create()
        {
            var model = new ProgramViewModel
            {
                Program = new EducationProgram(),
                Specializations = await _service.GetAllSpecialization()
            };
            return View(model);
        }

        // POST: ProgramController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProgramViewModel model)
        {
            if (ModelState.IsValid)
            {
                var id = await _service.AddProgram(model.Program, model.Image);
                if (id > 0)
                    return RedirectToAction("Index", "Program");
            }

            var viewModel = new ProgramViewModel
            {
                Specializations = await _service.GetAllSpecialization(),
                Program = model.Program
            };
            return View(viewModel);
        }

        // GET: ProgramController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var model = await _service.GetProgramById(id);
            if (model != null)
            {
                var viewModel = new ProgramEditViewModel
                {
                    Specializations = await _service.GetAllSpecialization(),
                    Program = model
                };
                return View(viewModel);
            }
            TempData["ErrorMessage"] = "Программы обучения не существует!";
            TempData["Page"] = "Index";
            TempData["Controller"] = "Program";
            return RedirectToAction("Error404", "Home");
        }

        // POST: ProgramController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ProgramEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var id = await _service.EditProgram(model.Program, model.Image);
                if (id)
                    return RedirectToAction("Index", "Program");
            }
            var viewModel = new ProgramEditViewModel
            {
                Specializations = await _service.GetAllSpecialization(),
                Program = model.Program
            };
            return View(viewModel);
        }

        // GET: ProgramController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var org = await _service.GetProgramById(id);
            if (org == null)
            {
                TempData["ErrorMessage"] = "Программы обучения не существует!";
                TempData["Page"] = "Index";
                TempData["Controller"] = "Program";
                return RedirectToAction("Error404", "Home");
            }
            var result = await _service.DeleteProgram(id);
            if (result)
                return RedirectToAction("Index", "Program");
            TempData["ErrorMessage"] = "Удаление не произошло, база недоступна!";
            TempData["Page"] = "Index";
            TempData["Controller"] = "Program";
            return RedirectToAction("Error404", "Home");
        }

        
    }
}
