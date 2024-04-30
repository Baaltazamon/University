using Data.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.Models;
using University.Service.UniService;

namespace University.Controllers
{
    [Authorize]
    public class PassingScoreController : Controller
    {
        private readonly ILogger<PassingScoreController> _logger;
        private readonly IUniService _service;

        public PassingScoreController(ILogger<PassingScoreController> logger, IUniService service)
        {
            _logger = logger;
            _service = service;
        }
        
        public async Task<ActionResult> Index(int id)
        {
            var organization = await _service.GetOrganizationProgramEducationalOrganization(id);
            if (organization is null)
            {
                TempData["ErrorMessage"] = "Учебной программы у учебного заведения не существует!";
                TempData["Page"] = "Index";
                TempData["Controller"] = "University";
                return RedirectToAction("Error404", "Home");
            }

            var model = new PassingScoreListModel
            {
                Name = organization.EducationProgram!.Name,
                Id = organization.Id,
                IdOrg = organization.EducationalOrganizationId,
                PassingScores = await _service.GetPassingScore(id)
            };

            return View(model);
        }
        
        // GET: PassingScoreController/Create
        public async Task<ActionResult> Create(int id)
        {
            var organization = await _service.GetOrganizationProgramEducationalOrganization(id);
            if (organization is null)
            {
                TempData["ErrorMessage"] = "Учебной программы у учебного заведения не существует!";
                TempData["Page"] = "Index";
                TempData["Controller"] = "University";
                return RedirectToAction("Error404", "Home");
            }

            var model = new PassingScoreViewModel
            {
                Name = organization.EducationProgram!.Name,
                Id = organization.EducationalOrganizationId,
                Score = new PassingScore { ProgramEducationalOrganizationId = id }
            };
            return View(model);
        }

        // POST: PassingScoreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PassingScoreViewModel model)
        {
            if (ModelState.IsValid)
            {
                var id = await _service.AddPassingScore(model.Score);
                if (id > 0)
                    return RedirectToAction("Index", "PassingScore", new { id = model.Score.ProgramEducationalOrganizationId });
            }
            var organization = await _service.GetOrganizationProgramEducationalOrganization(model.Score.ProgramEducationalOrganizationId);
            var viewModel = new PassingScoreViewModel()
            {
                Name = organization!.EducationProgram!.Name,
                Id = organization.EducationalOrganizationId,
                Score = model.Score
            };
            return View(viewModel);
        }
        

        // GET: PassingScoreController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _service.DeletePassingScore(id);
            if (result != 0) return RedirectToAction("Index", "PassingScore", new { id = result });
            TempData["ErrorMessage"] = "Результатов поступления не существует!";
            TempData["Page"] = "Index";
            TempData["Controller"] = "PassingScore";
            return RedirectToAction("Error404", "Home");
        }
        
    }
}
