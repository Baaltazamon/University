using Data.Dto;
using University.Models;

namespace University.Service.UniService
{
	public interface IUniService
    {
        public Task<UniModel> GetUniversity(EduOrgFilter filter);
    }
}
