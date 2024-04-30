using Data.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using University.Models;
using University.Service.UniService;

namespace University.Controllers
{
    [Authorize]
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;
        private readonly IUniService _service;

        public ContactController(ILogger<ContactController> logger, IUniService service)
        {
            _logger = logger;
            _service = service;
        }
        // GET: ContactController
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

            var model = await _service.GetContactListModel(id);
            model.Id = id;
            model.Name = organization.Name;
            return View(model);
        }

        
        // GET: ContactController/Create
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
            var model = new ContactViewModel
            {
                ContactTypes = await _service.GetTypesContact(),
                Contact = new EducationalOrganizationContact{EducationalOrganizationId = id},
            };
            return View(model);
        }

        // POST: ContactController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                var id = await _service.AddContact(model.Contact);
                if (id > 0)
                    return RedirectToAction("Index", "Contact", new {id = model.Contact.EducationalOrganizationId});
            }
            var viewModel = new ContactViewModel
            {
                ContactTypes = await _service.GetTypesContact(),
                Contact = model.Contact
            };
            return View(viewModel);
        }


        // GET: ContactController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _service.DeleteContact(id);
            if (result) return RedirectToAction("Index", "University");
            TempData["ErrorMessage"] = "Контакта не существует!";
            TempData["Page"] = "Index";
            TempData["Controller"] = "University";
            return RedirectToAction("Error404", "Home");
        }

        
    }
}
