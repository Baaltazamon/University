using Data.Context;

namespace University.Models;

public class ProgramDisciplineViewModel
{
    public DisciplineEducationProgram DisciplineEducationProgram { get; set; }
    public List<Discipline>? Disciplines { get; set; }
}