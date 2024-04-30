using System.ComponentModel.DataAnnotations;
using Data.Context;

namespace University.Models;

public class ProgramEditViewModel
{
    public List<Specialization>? Specializations { get; set; }
    public EducationProgram? Program { get; set; }
    public IFormFile? Image { get; set; }
}