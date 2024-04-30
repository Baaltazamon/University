using Data.Context;

namespace University.Models;

public class UniversityProgramViewModel
{
    public ProgramEducationalOrganization Program { get; set; }
    public List<EducationProgram>? Educations { get; set; }
    public List<EducationLevel>? EducationsLevel { get; set; }
}