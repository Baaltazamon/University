using System.ComponentModel.DataAnnotations;
using Data.Context;

namespace University.Models;

public class ProgramViewModel
{
    public List<Specialization>? Specializations { get; set; }
    public EducationProgram? Program { get; set; }
    [Required(ErrorMessage = "Выберите изображение для программы обучения.")]
    public IFormFile Image { get; set; }
}