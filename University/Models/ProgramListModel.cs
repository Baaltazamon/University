using Data.Context;

namespace University.Models;

public class ProgramListModel
{
    public List<EducationProgram> Programs { get; set; }
    public List<Specialization> Specializations { get; set; }
}