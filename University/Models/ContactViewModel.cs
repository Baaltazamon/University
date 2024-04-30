using Data.Context;

namespace University.Models
{
    public class ContactViewModel
    {
        public EducationalOrganizationContact Contact { get; set; }
        public List<TypeContact>? ContactTypes { get; set; }
    }
}
