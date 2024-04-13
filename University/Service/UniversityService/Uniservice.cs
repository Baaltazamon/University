using Data.Dto;
using Data.Repository.University;
using University.Models;
using University.Service.UniService;

namespace University.Service.UniversityService
{
    public class UniService : IUniService
    {
        private readonly IUniRepository _uniRepository;

        public UniService(IUniRepository uniRepository)
        {
            _uniRepository = uniRepository;
        }
        public async Task<UniModel> GetUniversity(EduOrgFilter filter)
        {

            var result = new UniModel(filters: filter,
                educationalOrganizations: await _uniRepository.GetFiltredOrganizations(filter),
                types: await _uniRepository.GetEducationalOrganizationType(), citys: await _uniRepository.GetCities(),
                specializations: await _uniRepository.GetAllSpecializations());
            return result;

        }

        public async Task<IndexModel> GetIndexModel()
        {
            var result = new IndexModel(images: await _uniRepository.GetRandomEducationProgram(5),
                educationPrograms: await _uniRepository.GetAllEducationProgram(),
                educationalOrganizations: await _uniRepository.GetRandomEducationalOrganization(6),
                randomVuzImage: (await _uniRepository.GetRandomEducationalOrganization(1)).First().Image);
            return result;
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
                Disciplines = await _uniRepository.GetAllDisciplines(),
                DisciplinesEducations = await _uniRepository.GetOrganizationProgramDisciplines(id),
                PassingScores = await _uniRepository.GetOrganizationPassingScore(id),
			};
            return result;
        }
    }
}
