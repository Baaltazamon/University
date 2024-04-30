using Data.Context;

namespace University.Models;

public class PassingScoreViewModel
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public PassingScore Score { get; set; }
}