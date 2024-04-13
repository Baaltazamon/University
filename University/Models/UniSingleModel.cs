using Data.Context;

namespace University.Models
{
	public class UniSingleModel
	{
		public EducationalOrganization? Organization { get; set; }
		public List<EducationProgram> Programs { get; set; }
		public TypeEducationalOrganization? OrganizationType { get; set; }
		public List<EducationalOrganizationContact> Contacts { get; set; }
		public List<TypeContact> ContactTypes { get; set; }
		public List<Specialization> Specializations { get; set; }
		public List<ProgramEducationalOrganization> ProgramEducationalOrganizations { get; set; }
		public List<EducationLevel> Levels { get; set; }
		public List<Discipline> Disciplines { get; set; }
		public List<DisciplineEducationProgram> DisciplinesEducations { get; set; }
		public List<PassingScore> PassingScores { get; set; }
	}
}
