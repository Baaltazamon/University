namespace Data.Dto
{
    public class EduOrgFilter
    {
        public string? Name { get; set; }
        public int? TypeId { get; set; }
        public int? CityId { get; set; }
        public List<int>? ProgramIds { get; set; }
    }
}
