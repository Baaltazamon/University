using Data.Dto;
using University.Models;

namespace University.Service.UniService
{
	public interface IUniService
    {
        public Task<UniModel> GetUniversity(EduOrgFilter filter);

        public Task<IndexModel> GetIndexModel();

        public Task<ProgramModel> GetProgramModel(int? id);

        public Task<UniSingleModel> GetSingleUniversity(int id);
    }
}
