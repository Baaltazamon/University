using System.ComponentModel.DataAnnotations;
using Data.Context;

namespace University.Models
{
    public class UniversityEditViewModel
    {
        public List<City>? Cities { get; set; }
        public List<TypeEducationalOrganization>? TypeEducationalOrganizations { get; set; }
        public EducationalOrganization? Organization { get; set; }
        public IFormFile? Image { get; set; }
    }
}
