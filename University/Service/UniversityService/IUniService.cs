using Data.Context;
using Data.Dto;
using University.Models;

namespace University.Service.UniService
{
	public interface IUniService
    {
        #region View Methods
        public Task<UniModel> GetUniversity(EduOrgFilter filter);
        public Task<bool> CheckUsers();
        public Task<IndexModel> GetIndexModel();
        public Task<List<EducationLevel>> GetAllLevels();
        public Task<ProgramModel> GetProgramModel(int? id);
        public Task<List<Discipline>> GetAllDisciplines();
        public Task<UniSingleModel> GetSingleUniversity(int id);

        #endregion

        #region Specialization Methods
        public Task<List<Specialization>> GetAllSpecialization();
        public Task<int> AddSpecialization(Specialization s);
        public Task<bool> DeleteSpecialization(int id);
        public Task<bool> EditSpecialization(Specialization s);
        public Task<Specialization?> GetSingleSpecialization(int id);


        #endregion

        #region Organization Methods
        public Task<List<EducationalOrganization>> GetAllEducationalOrganization();
        public Task<int> AddEducationalOrganization(EducationalOrganization s, IFormFile image);
        public Task<bool> EditEducationalOrganization(EducationalOrganization s, IFormFile? image);
        public Task<bool> DeleteEducationalOrganization(int id);
        public Task<EducationalOrganization?> GetSingleEducationalOrganization(int id);
        public Task<List<City>> GetCity();
        public Task<List<TypeEducationalOrganization>> GetTypes();

        #endregion

        #region ContactMethods
        public Task<ContactListModel> GetContactListModel(int id);
        public Task<List<TypeContact>> GetTypesContact();
        public Task<int> AddContact(EducationalOrganizationContact contact);
        public Task<bool> DeleteContact(int id);


        #endregion

        #region Education Program Methods
        public Task<ProgramListModel> GetProgramListModel();
        public Task<int> AddProgram(EducationProgram s, IFormFile image);
        public Task<bool> EditProgram(EducationProgram s, IFormFile? image);
        public Task<bool> DeleteProgram(int id);
        public Task<EducationProgram?> GetProgramById(int id);
        public Task<List<EducationProgram>> GetAllPrograms();

        #endregion

        #region University program methods

        public Task<ProgramUniListModel> GetProgramUniListModel(int id);
        public Task<int> AddProgramUni(ProgramEducationalOrganization model);
        public Task<int> DeleteProgramUni(int id);
        public Task<ProgramEducationalOrganization?> GetOrganizationProgramEducationalOrganization(int id);

        #endregion

        #region Disciplines in education program
        public Task<List<DisciplineEducationProgram>> GetDisciplineList(int id);
        public Task<int> AddDisciplineEducationProgram(DisciplineEducationProgram model);
        public Task<int> DeleteDisciplineEducationProgram(int id);

        #endregion

        #region Passing score

        public Task<List<PassingScore>> GetPassingScore(int id);
        public Task<int> AddPassingScore(PassingScore entity);
        public Task<int> DeletePassingScore(int id);

        #endregion

    }
}
