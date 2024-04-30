using Data.Context;

namespace University.Models;

public class PassingScoreListModel
{
    public int Id { get; set; }
    public int IdOrg { get; set; }
    public string Name { get; set; }
    public List<PassingScore> PassingScores { get; set; }
}