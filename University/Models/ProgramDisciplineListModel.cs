using Data.Context;

namespace University.Models;

public class ProgramDisciplineListModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<DisciplineEducationProgram> DisciplineEducationPrograms { get; set; }
    public List<Discipline> Disciplines { get; set; }
}