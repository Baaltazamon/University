using Data.Context;

namespace University.Models
{
    public class ContactListModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<EducationalOrganizationContact> Contacts { get; set; }
        public List<TypeContact> TypeContacts { get; set; }
    }
}
