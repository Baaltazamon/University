using Data.Context;
using Data.Dto;

namespace University.Models
{
    public class UniModel
    {
        public UniModel()
        {
        }

        public UniModel(EduOrgFilter filters, List<EducationalOrganization> educationalOrganizations, List<TypeEducationalOrganization?> types, 
            List<City> citys, List<Specialization> specializations)
        {
            Filters = filters;
            EducationalOrganizations = educationalOrganizations;
            Types = types;
            Citys = citys;
            Specializations = specializations;
        }

        public List<TypeEducationalOrganization?> Types { get; set; }
        public List<EducationalOrganization> EducationalOrganizations { get; set; }
        public EduOrgFilter Filters { get; set; }
        public List<City> Citys { get; set; }
        public List<Specialization> Specializations { get; set; }
    }
}
