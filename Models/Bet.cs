namespace BetMe.Models;

public class Bet
{
    public long Id { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public long CreatorId { get; set; }
    public DateTime CreatedAt { get; set; }
    public BetStatus Status { get; set; }
    public long WinOutcomeId { get; set; } = -1;

    public Bet(string name, string description, long creatorId)
    {
        Name = name;
        Description = description;
        CreatorId = creatorId;
        CreatedAt = DateTime.UtcNow;
        Status = BetStatus.Creating;
    }
}