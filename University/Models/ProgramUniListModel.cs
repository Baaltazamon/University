using Data.Context;

namespace University.Models;

public class ProgramUniListModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<ProgramEducationalOrganization> UniPrograms { get; set; }
    public List<EducationProgram> Programs { get; set; }
    public List<Specialization> Specializations { get; set; }
    public List<EducationLevel> EducationLevels { get; set; }
}