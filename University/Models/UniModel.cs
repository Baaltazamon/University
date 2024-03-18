using Data.Context;
using Data.Dto;

namespace University.Models
{
    public class UniModel
    {
        public List<TypeEducationalOrganization> Types { get; set; }
        public List<EducationalOrganization> EducationalOrganizations { get; set; }
        public EduOrgFilter Filters { get; set; }
        public List<City> Citys { get; set; }
        public List<Specialization> Specializations { get; set; }
    }

    
}
