using System.ComponentModel.DataAnnotations;
using Data.Context;

namespace University.Models
{
    public class UniversityViewModel
    {
        public List<City>? Cities { get; set; }
        public List<TypeEducationalOrganization>? TypeEducationalOrganizations { get; set; }
        public EducationalOrganization? Organization { get; set; }
        [Required(ErrorMessage = "Выберите фото вуза.")]
        public IFormFile Image { get; set; }
    }
}
