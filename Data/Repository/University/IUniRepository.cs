using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dto;

namespace Data.Repository.University
{
    public interface IUniRepository
    {
        public Task<List<EducationalOrganization>> GetAllEducationalOrganization();
        public Task<List<EducationalOrganization>> GetRandomEducationalOrganization(int count);
        public Task<EducationalOrganization?> GetEducationalOrganization(int id);
        public Task<bool> EditEducationalOrganization(EducationalOrganization entity);
        public Task<bool> DeleteEducationalOrganization(int id);
        public Task<int> AddEducationalOrganization(EducationalOrganization entity);
        public Task<List<EducationalOrganization>> GetFiltredOrganizations(EduOrgFilter filter);

        public Task<List<EducationalOrganizationContact>> GetEducationalOrganizationContact(int organizationId);
        public Task<List<TypeContact>> GetAllType();

        public Task<List<Specialization>> GetAllSpecializations();
        public Task<Specialization?> GetSpecialization(int id);
        public Task<List<Specialization>> GetSpecializationOnUniversity(int id);
        public Task<bool> EditSpecialization(Specialization entity);
        public Task<int> AddSpecialization(Specialization entity);
        public Task<bool> DeleteSpecialization(int id);

        public Task<List<EducationProgram>> GetAllEducationProgram();
        public Task<List<string?>> GetRandomEducationProgram(int count);
        public Task<EducationProgram?> GetEducationProgram(int id);
        public Task<List<EducationProgram>> GetOrganizationEducationProgram(int id);
        public Task<bool> EditEducationProgram(EducationProgram entity);
        public Task<int> AddEducationProgram(EducationProgram entity);

        public Task<List<TypeEducationalOrganization?>> GetEducationalOrganizationType();
        public Task<TypeEducationalOrganization?> GetEducationalOrganizationTypeOnOrganization(int id);
        public Task<List<City>> GetCities();

        public Task<List<ProgramEducationalOrganization>> GetProgramEducationalOrganization(int id);
        public Task<List<EducationLevel>> GetAllEducationalLevel();
        public Task<List<Discipline>> GetAllDisciplines();
        public Task<List<DisciplineEducationProgram>> GetOrganizationProgramDisciplines(int id);
        public Task<List<PassingScore>> GetOrganizationPassingScore(int id);
    }
}
