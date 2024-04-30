using Data.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.Models;
using University.Service.UniService;

namespace University.Controllers
{
    [Authorize]
    public class UniversityProgramController : Controller
    {
        private readonly ILogger<UniversityProgramController> _logger;
        private readonly IUniService _service;

        public UniversityProgramController(ILogger<UniversityProgramController> logger, IUniService service)
        {
            _logger = logger;
            _service = service;
        }
        // GET: UniversityProgramController
        public async Task<ActionResult> Index(int id)
        {
            var organization = await _service.GetSingleEducationalOrganization(id);
            if (organization is null)
            {
                TempData["ErrorMessage"] = "Учебное заведение не существует!";
                TempData["Page"] = "Index";
                TempData["Controller"] = "University";
                return RedirectToAction("Error404", "Home");
            }
            TempData["UniId"] = id;
            var model = await _service.GetProgramUniListModel(id);
            model.Id = id;
            model.Name = organization.Name;
            return View(model);
        }
        
        // GET: UniversityProgramController/Create
        public async Task<ActionResult> Create(int id)
        {
            var organization = await _service.GetSingleEducationalOrganization(id);
            if (organization is null)
            {
                TempData["ErrorMessage"] = "Учебное заведение не существует!";
                TempData["Page"] = "Index";
                TempData["Controller"] = "University";
                return RedirectToAction("Error404", "Home");
            }
            TempData["UniId"] = id;
            var model = new UniversityProgramViewModel
            {
                Program = new ProgramEducationalOrganization { EducationalOrganizationId = id },
                Educations = await _service.GetAllPrograms(),
                EducationsLevel = await _service.GetAllLevels()
            };
            return View(model);
        }

        // POST: UniversityProgramController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(UniversityProgramViewModel model)
        {
            if (ModelState.IsValid)
            {
                var id = await _service.AddProgramUni(model.Program);
                if (id > 0)
                    return RedirectToAction("Index", "UniversityProgram", new { id = model.Program.EducationalOrganizationId });
            }
            var viewModel = new UniversityProgramViewModel
            {
                Program = model.Program,
                Educations = await _service.GetAllPrograms(),
                EducationsLevel = await _service.GetAllLevels()
            };
            return View(viewModel);
        }
        
        
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _service.DeleteProgramUni(id);
            if (result != 0) return RedirectToAction("Index", "UniversityProgram", new {id = result });
            TempData["ErrorMessage"] = "Программы не существует!";
            TempData["Page"] = "Index";
            TempData["Controller"] = "University";
            return RedirectToAction("Error404", "Home");
        }
        
    }
}
