using Data.Context;
using Data.Dto;
using Data.Repository.University;
using Microsoft.AspNetCore.Hosting;
using University.Models;
using University.Service.UniService;

namespace University.Service.UniversityService
{
    public class UniService : IUniService
    {
        private readonly IUniRepository _uniRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public UniService(IUniRepository uniRepository, IWebHostEnvironment webHostEnvironment)
        {
            _uniRepository = uniRepository;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<UniModel> GetUniversity(EduOrgFilter filter)
        {

            var result = new UniModel(filters: filter,
                educationalOrganizations: await _uniRepository.GetFiltredOrganizations(filter),
                types: await _uniRepository.GetEducationalOrganizationType(), citys: await _uniRepository.GetCities(),
                specializations: await _uniRepository.GetAllSpecializations());
            return result;

        }

        public Task<bool> CheckUsers()
        {
            return _uniRepository.CheckUsers();
        }

        public async Task<IndexModel> GetIndexModel()
        {
            var result = new IndexModel(images: await _uniRepository.GetRandomEducationProgram(5),
                educationPrograms: await _uniRepository.GetAllEducationProgram(),
                educationalOrganizations: await _uniRepository.GetRandomEducationalOrganization(6),
                randomVuzImage: (await _uniRepository.GetRandomEducationalOrganization(1)).First().Image);
            return result;
        }

        public async Task<List<EducationLevel>> GetAllLevels()
        {
            return await _uniRepository.GetAllEducationalLevel();
        }

        public async Task<ProgramModel> GetProgramModel(int? id)
        {
            if (id == null)
            {
                return new ProgramModel
                {
                    EducationPrograms = await _uniRepository.GetAllEducationProgram(),
                    Specializations = await _uniRepository.GetAllSpecializations()
                };
            }

            return new ProgramModel
            {
                EducationPrograms = await _uniRepository.GetOrganizationEducationProgram(id.Value),
                Specializations = await _uniRepository.GetAllSpecializations()
            };
        }

        public async Task<List<Discipline>> GetAllDisciplines()
        {
            return await _uniRepository.GetAllDisciplines();
        }

        public async Task<UniSingleModel> GetSingleUniversity(int id)
        {
            var result = new UniSingleModel
            {
                Contacts = await _uniRepository.GetEducationalOrganizationContact(id),
                Programs = await _uniRepository.GetOrganizationEducationProgram(id),
                Organization = await _uniRepository.GetEducationalOrganization(id),
                OrganizationType = await _uniRepository.GetEducationalOrganizationTypeOnOrganization(id),
                ContactTypes = await _uniRepository.GetAllType(),
                Specializations = await _uniRepository.GetSpecializationOnUniversity(id),
                ProgramEducationalOrganizations = await _uniRepository.GetProgramEducationalOrganization(id),
                Levels = await _uniRepository.GetAllEducationalLevel(),
                Disciplines = await GetAllDisciplines(),
                DisciplinesEducations = await _uniRepository.GetOrganizationProgramDisciplines(id),
                PassingScores = await _uniRepository.GetOrganizationPassingScore(id),
            };
            return result;
        }

        public async Task<List<Specialization>> GetAllSpecialization()
        {
            return await _uniRepository.GetAllSpecializations();
        }

        public async Task<int> AddSpecialization(Specialization s)
        {
            return await _uniRepository.AddSpecialization(s);
        }

        public async Task<bool> DeleteSpecialization(int id)
        {
            return await _uniRepository.DeleteSpecialization(id);
        }

        public async Task<bool> EditSpecialization(Specialization s)
        {
            return await _uniRepository.EditSpecialization(s);
        }

        public async Task<Specialization?> GetSingleSpecialization(int id)
        {
            return await _uniRepository.GetSpecialization(id);
        }

        public async Task<List<EducationalOrganization>> GetAllEducationalOrganization()
        {
            return await _uniRepository.GetAllEducationalOrganization();
        }

        public async Task<int> AddEducationalOrganization(EducationalOrganization s, IFormFile image)
        {
            if (image.Length == 0)
            {
                s.Image = "";
                return await _uniRepository.AddEducationalOrganization(s);
            };
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
            s.Image = fileName;
            var result = await SaveImage(image, fileName, "vuz");

            if (result)
                return await _uniRepository.AddEducationalOrganization(s);
            return 0;
        }

        public async Task<bool> EditEducationalOrganization(EducationalOrganization s, IFormFile? image)
        {
            if (image == null)
            {
                return await _uniRepository.EditEducationalOrganization(s);
            };
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
            s.Image = fileName;
            var result = await SaveImage(image, fileName, "vuz");
            
            if (result)
                return await _uniRepository.EditEducationalOrganization(s);
            return false;
        }

        public async Task<bool> DeleteEducationalOrganization(int id)
        {
            return await _uniRepository.DeleteEducationalOrganization(id);
        }

        public async Task<EducationalOrganization?> GetSingleEducationalOrganization(int id)
        {
            return await _uniRepository.GetEducationalOrganization(id);
        }

        public async Task<List<City>> GetCity()
        {
            return await _uniRepository.GetCities();
        }

        public async Task<List<TypeEducationalOrganization>> GetTypes()
        {
            return await _uniRepository.GetTypesEducationalOrganization();
        }

        public async Task<ContactListModel> GetContactListModel(int id)
        {
            var model = new ContactListModel
            {
                Contacts = await _uniRepository.GetEducationalOrganizationContact(id),
                TypeContacts = await _uniRepository.GetAllType()
            };
            return model;
        }

        public async Task<List<TypeContact>> GetTypesContact()
        {
            return await _uniRepository.GetAllType();
        }

        public Task<int> AddContact(EducationalOrganizationContact contact)
        {
            return _uniRepository.AddContact(contact);
        }

        public Task<bool> DeleteContact(int id)
        {
            return _uniRepository.DeleteContact(id);
        }

        public async Task<ProgramListModel> GetProgramListModel()
        {
            return new ProgramListModel
            {
                Programs = await GetAllPrograms(),
                Specializations = await GetAllSpecialization()
            };
        }

        public async Task<int> AddProgram(EducationProgram s, IFormFile image)
        {
            if (image.Length == 0)
            {
                s.Image = "";
                return await _uniRepository.AddEducationProgram(s);
            };
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
            s.Image = fileName;
            var result = await SaveImage(image, fileName, "spec");

            if (result)
                return await _uniRepository.AddEducationProgram(s);
            return 0;
        }

        public async Task<bool> EditProgram(EducationProgram s, IFormFile? image)
        {
            if (image == null)
            {
                return await _uniRepository.EditEducationProgram(s);
            };
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
            s.Image = fileName;
            var result = await SaveImage(image, fileName, "spec");

            if (result)
                return await _uniRepository.EditEducationProgram(s);
            return false;
        }

        public async Task<bool> DeleteProgram(int id)
        {
            return await _uniRepository.DeleteEducationProgram(id);
        }

        public async Task<EducationProgram?> GetProgramById(int id)
        {
            return await _uniRepository.GetEducationProgram(id);
        }

        public async Task<List<EducationProgram>> GetAllPrograms()
        {
            return await _uniRepository.GetAllEducationProgram();
        }

        public async Task<ProgramUniListModel> GetProgramUniListModel(int id)
        {
            var model = new ProgramUniListModel
            {
                Programs = await GetAllPrograms(),
                UniPrograms = await _uniRepository.GetProgramEducationalOrganization(id),
                Specializations = await GetAllSpecialization(),
                EducationLevels = await GetAllLevels()
            };
            return model;
        }

        public async Task<int> AddProgramUni(ProgramEducationalOrganization model)
        {
            return await _uniRepository.AddProgramEducationOrganization(model);
        }

        public async Task<int> DeleteProgramUni(int id)
        {
            return await _uniRepository.DeleteProgramEducationOrganization(id);
        }

        public async Task<ProgramEducationalOrganization?> GetOrganizationProgramEducationalOrganization(int id)
        {
            return await _uniRepository.GetOrganizationProgramEducationalOrganization(id);
        }

        public async Task<List<DisciplineEducationProgram>> GetDisciplineList(int id)
        {
            return await _uniRepository.GetDisciplineEducationPrograms(id);
        }

        public async Task<int> AddDisciplineEducationProgram(DisciplineEducationProgram model)
        {
            return await _uniRepository.AddDisciplineEducationProgram(model);
        }

        public async Task<int> DeleteDisciplineEducationProgram(int id)
        {
            return await _uniRepository.DeleteDisciplineEducationPrograms(id);
        }

        public async Task<List<PassingScore>> GetPassingScore(int id)
        {
            return await _uniRepository.GetPassingScore(id);
        }

        public async Task<int> AddPassingScore(PassingScore entity)
        {
            return await _uniRepository.AddPassingScore(entity);
        }

        public async Task<int> DeletePassingScore(int id)
        {
            return await _uniRepository.DeletePassingScore(id);
        }

        private async Task<bool> SaveImage(IFormFile image, string fileName, string folder)
        {
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "assets", "img", folder, fileName);

            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            await using var stream = new FileStream(filePath, FileMode.Create);
            await image.CopyToAsync(stream);
            return true;
        }
    }
}
