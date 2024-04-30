using Data.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.Models;
using University.Service.UniService;

namespace University.Controllers
{
    [Authorize]
    public class ProgramDisciplineController : Controller
    {
        private readonly ILogger<ProgramDisciplineController> _logger;
        private readonly IUniService _service;

        public ProgramDisciplineController(ILogger<ProgramDisciplineController> logger, IUniService service)
        {
            _logger = logger;
            _service = service;
        }


        public async Task<ActionResult> Index(int id)
        {
            var prog = await _service.GetProgramById(id);
            if (prog is null)
            {
                TempData["ErrorMessage"] = "Учебной программы не существует!";
                TempData["Page"] = "Index";
                TempData["Controller"] = "Program";
                return RedirectToAction("Error404", "Home");
            }

            var model = new ProgramDisciplineListModel
            {
                Id = prog.Id,
                Name = prog.Name,
                Disciplines = await _service.GetAllDisciplines(),
                DisciplineEducationPrograms = await _service.GetDisciplineList(id)
            };
            return View(model);
        }


        // GET: ProgramDisciplineController/Create
        public async Task<ActionResult> Create(int id)
        {
            var organization = await _service.GetProgramById(id);
            if (organization is null)
            {
                TempData["ErrorMessage"] = "Учебной программы не существует!";
                TempData["Page"] = "Index";
                TempData["Controller"] = "Program";
                return RedirectToAction("Error404", "Home");
            }
            var model = new ProgramDisciplineViewModel()
            {
                Disciplines = await _service.GetAllDisciplines(),
                DisciplineEducationProgram = new DisciplineEducationProgram{EducationProgramId = id}
            };
            return View(model);
        }

        // POST: ProgramDisciplineController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProgramDisciplineViewModel model)
        {
            if (ModelState.IsValid)
            {
                var id = await _service.AddDisciplineEducationProgram(model.DisciplineEducationProgram);
                if (id > 0)
                    return RedirectToAction("Index", "ProgramDiscipline", new { id = model.DisciplineEducationProgram.EducationProgramId });
            }
            var viewModel = new ProgramDisciplineViewModel()
            {
                Disciplines = await _service.GetAllDisciplines(),
                DisciplineEducationProgram = model.DisciplineEducationProgram
            };
            return View(viewModel);
        }

        // GET: ProgramDisciplineController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _service.DeleteDisciplineEducationProgram(id);
            if (result > 0) return RedirectToAction("Index", "ProgramDiscipline", new {id = result});
            TempData["ErrorMessage"] = "Предмета для поступления по текущей программе не существует!";
            TempData["Page"] = "Index";
            TempData["Controller"] = "Program";
            return RedirectToAction("Error404", "Home");
        }
    }
}
