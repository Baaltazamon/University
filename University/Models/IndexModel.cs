using Data.Context;

namespace University.Models;

public class IndexModel
{
    public IndexModel()
    {
    }

    public IndexModel(List<string?> images, List<EducationProgram> educationPrograms, List<EducationalOrganization> educationalOrganizations, string? randomVuzImage)
    {
        Images = images;
        EducationPrograms = educationPrograms;
        EducationalOrganizations = educationalOrganizations;
        RandomVuzImage = randomVuzImage;
    }

    public List<string?> Images { get; set; }
    public List<EducationalOrganization> EducationalOrganizations { get; set; }
    public List<EducationProgram> EducationPrograms { get; set; }
    public string? RandomVuzImage { get; set; }
}