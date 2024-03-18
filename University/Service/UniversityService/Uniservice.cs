using Data.Dto;
using Data.Repository.University;
using University.Models;
using University.Service.UniService;

namespace University.Service.UniversityService
{
    public class Uniservice : IUniService
    {
        private readonly IUniRepository _uniRepository;

        public Uniservice(IUniRepository uniRepository)
        {
            _uniRepository = uniRepository;
        }
        public async Task<UniModel> GetUniversity(EduOrgFilter filter)
        {
            UniModel result = new UniModel();
            result.Filters = filter;
            result.EducationalOrganizations = await _uniRepository.GetFiltredOrganizations(filter);
            result.Types = await _uniRepository.GetEducationalOrganizationType();
            result.Citys = await _uniRepository.GetCities();
            result.Specializations = await _uniRepository.GetAllSpecializations();
            return result;

        }
    }
}
